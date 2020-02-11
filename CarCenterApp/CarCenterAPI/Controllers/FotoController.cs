using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarCenterAPI.Converts;
using CarCenterAPI.Models;
using CarCenterCore.Servicios;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarCenterAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FotoController : ControllerBase
    {
        private readonly IFotoServicio _FotoServicio;
        public FotoController(IFotoServicio FotoServicio)
        {
            _FotoServicio = FotoServicio;
        }

        [HttpPost("Crear")]
        public async Task<IActionResult> Crear([FromBody]FotoModel model)
        {
            var Foto = await _FotoServicio.CrearFoto(FotoConvert.toEntity(model));
            if (Foto != null)
            {
                return Ok(FotoConvert.toModel(Foto));
            }
            else
            {
                ResponseModel response = new ResponseModel()
                {
                    Mensaje = "No se pudo crear el Foto",
                    Estado = 200
                };
                return Ok(response);
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> ObtenerPorId(string id)
        {
            var guid = Guid.Parse(id);
            var Foto = await _FotoServicio.ObtenerFotoPorId(guid);
            if (Foto == null) { return NotFound(); } else { return Ok(FotoConvert.toModel(Foto)); }
        }

        [HttpGet]
        public async Task<IActionResult> obtenerTodos()
        {
            var resultado = await _FotoServicio.ObtenerFotos();
            if (resultado.Count() >= 1) { return Ok(FotoConvert.toListModel(resultado)); }
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
        public async Task<IActionResult> actualizar([FromBody]FotoModel modelo)
        {
            var Foto = await _FotoServicio.ActualizarFoto(FotoConvert.toEntity(modelo));
            if (Foto != null)
            {
                return Ok(FotoConvert.toModel(Foto));
            }
            else
            {
                ResponseModel response = new ResponseModel()
                {
                    Estado = 200,
                    Mensaje = "No se pudo actualizar el Foto"
                };
                return Ok(response);
            }
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> eliminarFoto(string id)
        {
            var guid = Guid.Parse(id);
            var resultado = await _FotoServicio.EliminarFoto(guid);
            if (resultado)
            {
                ResponseModel response = new ResponseModel()
                {
                    Mensaje = "Foto eliminado",
                    Estado = 200
                };
                return Ok(response);
            }
            else
            {
                ResponseModel response = new ResponseModel()
                {
                    Mensaje = "Foto no se pudo eliminar",
                    Estado = 200
                };
                return Ok(response);
            }
        }

    }
}