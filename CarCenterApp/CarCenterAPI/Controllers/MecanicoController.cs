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
    public class MecanicoController : ControllerBase
    {
        private readonly IMecanicoServicio _MecanicoServicio;

        public MecanicoController(IMecanicoServicio MecanicoServicio)
        {
            _MecanicoServicio = MecanicoServicio;
        }

        [HttpPost("Crear")]
        public async Task<IActionResult> Crear([FromBody]MecanicoModel model)
        {
            var Mecanico = await _MecanicoServicio.CrearMecanico(MecanicoConvert.toEntity(model));
            if (Mecanico != null)
            {
                return Ok(MecanicoConvert.toModel(Mecanico));
            }
            else
            {
                ResponseModel response = new ResponseModel()
                {
                    Mensaje = "No se pudo crear el Mecanico",
                    Estado = 200
                };
                return Ok(response);
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> ObtenerPorId(string id)
        {
            var guid = Guid.Parse(id);
            var Mecanico = await _MecanicoServicio.ObtenerMecanicoPorId(guid);
            if (Mecanico == null) { return NotFound(); } else { return Ok(MecanicoConvert.toModel(Mecanico)); }
        }

        [HttpGet]
        public async Task<IActionResult> obtenerTodos()
        {
            var resultado = await _MecanicoServicio.ObtenerMecanicos();
            if (resultado.Count() >= 1) { return Ok(MecanicoConvert.toListModel(resultado)); }
            else
            {
                ResponseModel response = new ResponseModel()
                {
                    Estado = 200,
                    Mensaje = "No hay registros!!"
                };
                return Ok(response);
            }
        }

        [HttpPut("actualizar")]
        public async Task<IActionResult> actualizar([FromBody]MecanicoModel modelo)
        {
            var Mecanico = await _MecanicoServicio.ActualizarMecanico(MecanicoConvert.toEntity(modelo));
            if (Mecanico != null)
            {
                return Ok(MecanicoConvert.toModel(Mecanico));
            }
            else
            {
                ResponseModel response = new ResponseModel()
                {
                    Estado = 200,
                    Mensaje = "No se pudo actualizar el Mecanico"
                };
                return Ok(response);
            }
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> eliminarMecanico(string id)
        {
            var guid = Guid.Parse(id);
            var resultado = await _MecanicoServicio.EliminarMecanico(guid);
            if (resultado)
            {
                ResponseModel response = new ResponseModel()
                {
                    Mensaje = "Mecanico eliminado",
                    Estado = 200
                };
                return Ok(response);
            }
            else
            {
                ResponseModel response = new ResponseModel()
                {
                    Mensaje = "Mecanico no se pudo eliminar",
                    Estado = 200
                };
                return Ok(response);
            }
        }
    }
}
