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
    public class MantenimientoController : ControllerBase
    {
        private readonly IMantenimientoServicio _MantenimientoServicio;

        public MantenimientoController(IMantenimientoServicio MantenimientoServicio)
        {
            _MantenimientoServicio = MantenimientoServicio;
        }

        [HttpPost("Crear")]
        public async Task<IActionResult> Crear([FromBody]MantenimientoModel model)
        {
            var Mantenimiento = await _MantenimientoServicio.CrearMantenimiento(MantenimientoConvert.toEntity(model));
            if (Mantenimiento != null)
            {
                return Ok(MantenimientoConvert.toModel(Mantenimiento));
            }
            else
            {
                ResponseModel response = new ResponseModel()
                {
                    Mensaje = "No se pudo crear el Mantenimiento",
                    Estado = 200
                };
                return Ok(response);
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> ObtenerPorId(string id)
        {
            var guid = Guid.Parse(id);
            var Mantenimiento = await _MantenimientoServicio.ObtenerMantenimientoPorId(guid);
            if (Mantenimiento == null) { return NotFound(); } else { return Ok(MantenimientoConvert.toModel(Mantenimiento)); }
        }

        [HttpGet]
        public async Task<IActionResult> obtenerTodos()
        {
            var resultado = await _MantenimientoServicio.ObtenerMantenimientos();
            if (resultado.Count() >= 1) { return Ok(MantenimientoConvert.toListModel(resultado)); }
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
        public async Task<IActionResult> actualizar([FromBody]MantenimientoModel modelo)
        {
            var Mantenimiento = await _MantenimientoServicio.ActualizarMantenimiento(MantenimientoConvert.toEntity(modelo));
            if (Mantenimiento != null)
            {
                return Ok(MantenimientoConvert.toModel(Mantenimiento));
            }
            else
            {
                ResponseModel response = new ResponseModel()
                {
                    Estado = 200,
                    Mensaje = "No se pudo actualizar el Mantenimiento"
                };
                return Ok(response);
            }
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> eliminarMantenimiento(string id)
        {
            var guid = Guid.Parse(id);
            var resultado = await _MantenimientoServicio.EliminarMantenimiento(guid);
            if (resultado)
            {
                ResponseModel response = new ResponseModel()
                {
                    Mensaje = "Mantenimiento eliminado",
                    Estado = 200
                };
                return Ok(response);
            }
            else
            {
                ResponseModel response = new ResponseModel()
                {
                    Mensaje = "Mantenimiento no se pudo eliminar",
                    Estado = 200
                };
                return Ok(response);
            }
        }
    }
}
