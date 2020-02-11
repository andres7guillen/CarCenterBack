using CarCenterAPI.Converts;
using CarCenterAPI.Models;
using CarCenterCore.Servicios;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarCenterAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServicioController : ControllerBase
    {
        private readonly IServicioServicio _ServicioServicio;
        public ServicioController(IServicioServicio ServicioServicio)
        {
            _ServicioServicio = ServicioServicio;
        }

        [HttpPost("Crear")]
        public async Task<IActionResult> Crear([FromBody]ServicioModel model)
        {
            var Servicio = await _ServicioServicio.CrearServicio(ServicioConvert.toEntity(model));
            if (Servicio != null)
            {
                return Ok(ServicioConvert.toModel(Servicio));
            }
            else
            {
                ResponseModel response = new ResponseModel()
                {
                    Mensaje = "No se pudo crear el Servicio",
                    Estado = 200
                };
                return Ok(response);
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> ObtenerPorId(string id)
        {
            var guid = Guid.Parse(id);
            var Servicio = await _ServicioServicio.ObtenerServicioPorId(guid);
            if (Servicio == null) { return NotFound(); } else { return Ok(ServicioConvert.toModel(Servicio)); }
        }

        [HttpGet]
        public async Task<IActionResult> obtenerTodos()
        {
            var resultado = await _ServicioServicio.ObtenerServicios();
            if (resultado.Count() >= 1) { return Ok(ServicioConvert.toListModel(resultado)); }
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
        public async Task<IActionResult> actualizar([FromBody]ServicioModel modelo)
        {
            var Servicio = await _ServicioServicio.ActualizarServicio(ServicioConvert.toEntity(modelo));
            if (Servicio != null)
            {
                return Ok(ServicioConvert.toModel(Servicio));
            }
            else
            {
                ResponseModel response = new ResponseModel()
                {
                    Estado = 200,
                    Mensaje = "No se pudo actualizar el Servicio"
                };
                return Ok(response);
            }
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> eliminarServicio(string id)
        {
            var guid = Guid.Parse(id);
            var resultado = await _ServicioServicio.EliminarServicio(guid);
            if (resultado)
            {
                ResponseModel response = new ResponseModel()
                {
                    Mensaje = "Servicio eliminado",
                    Estado = 200
                };
                return Ok(response);
            }
            else
            {
                ResponseModel response = new ResponseModel()
                {
                    Mensaje = "Servicio no se pudo eliminar",
                    Estado = 200
                };
                return Ok(response);
            }
        }

    }
}
