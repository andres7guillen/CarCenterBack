using CarCenterAPI.Converts;
using CarCenterAPI.Models;
using CarCenterCore.Servicios;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarCenterAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class MarcaController : ControllerBase
    {
        private readonly IMarcaServicio _MarcaServicio;

        public MarcaController(IMarcaServicio MarcaServicio)
        {
            _MarcaServicio = MarcaServicio;
        }

        [HttpPost("Crear")]
        public async Task<IActionResult> Crear([FromBody]MarcaModel model)
        {
            var Marca = await _MarcaServicio.CrearMarca(MarcaConvert.toEntity(model));
            if (Marca != null)
            {
                return Ok(MarcaConvert.toModel(Marca));
            }
            else
            {
                ResponseModel response = new ResponseModel()
                {
                    Mensaje = "No se pudo crear el Marca",
                    Estado = 200
                };
                return Ok(response);
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> ObtenerPorId(string id)
        {
            var guid = Guid.Parse(id);
            var Marca = await _MarcaServicio.ObtenerMarcaPorId(guid);
            if (Marca == null) { return NotFound(); } else { return Ok(MarcaConvert.toModel(Marca)); }
        }

        [HttpGet]
        public async Task<IActionResult> obtenerTodos()
        {
            var resultado = await _MarcaServicio.ObtenerMarcas();
            if (resultado.Count() >= 1) { return Ok(MarcaConvert.toListModel(resultado)); }
            else
            {
                ResponseModel response = new ResponseModel()
                {
                    Estado = 200,
                    Mensaje = "No hay registros!!"
                };
                return BadRequest(response);
            }
        }

        [HttpPut("actualizar")]
        public async Task<IActionResult> actualizar([FromBody]MarcaModel modelo)
        {
            var Marca = await _MarcaServicio.ActualizarMarca(MarcaConvert.toEntity(modelo));
            if (Marca != null)
            {
                return Ok(MarcaConvert.toModel(Marca));
            }
            else
            {
                ResponseModel response = new ResponseModel()
                {
                    Estado = 200,
                    Mensaje = "No se pudo actualizar el Marca"
                };
                return Ok(response);
            }
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> eliminarMarca(string id)
        {
            var guid = Guid.Parse(id);
            var resultado = await _MarcaServicio.EliminarMarca(guid);
            if (resultado)
            {
                ResponseModel response = new ResponseModel()
                {
                    Mensaje = "Marca eliminado",
                    Estado = 200
                };
                return Ok(response);
            }
            else
            {
                ResponseModel response = new ResponseModel()
                {
                    Mensaje = "Marca no se pudo eliminar",
                    Estado = 200
                };
                return Ok(response);
            }
        }
    }
}
