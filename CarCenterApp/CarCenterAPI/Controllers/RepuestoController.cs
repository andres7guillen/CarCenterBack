using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarCenterAPI.Converts;
using CarCenterAPI.Models;
using CarCenterCore.Servicios;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarCenterAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class RepuestoController : ControllerBase
    {
        private readonly IRepuestoServicio _RepuestoServicio;

        public RepuestoController(IRepuestoServicio RepuestoServicio)
        {
            _RepuestoServicio = RepuestoServicio;
        }

        [HttpPost("Crear")]
        public async Task<IActionResult> Crear([FromBody]RepuestoModel model)
        {
            var Repuesto = await _RepuestoServicio.CrearRepuesto(RepuestoConvert.toEntity(model));
            if (Repuesto != null)
            {
                return Ok(RepuestoConvert.toModel(Repuesto));
            }
            else
            {
                ResponseModel response = new ResponseModel()
                {
                    Mensaje = "No se pudo crear el Repuesto",
                    Estado = 200
                };
                return Ok(response);
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> ObtenerPorId(string id)
        {
            var guid = Guid.Parse(id);
            var Repuesto = await _RepuestoServicio.ObtenerRepuestoPorId(guid);
            if (Repuesto == null) { return NotFound(); } else { return Ok(RepuestoConvert.toModel(Repuesto)); }
        }

        [HttpGet]
        public async Task<IActionResult> obtenerTodos()
        {
            var resultado = await _RepuestoServicio.ObtenerRepuestos();
            if (resultado.Count() >= 1) { return Ok(RepuestoConvert.toListModel(resultado)); }
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
        public async Task<IActionResult> actualizar([FromBody]RepuestoModel modelo)
        {
            var Repuesto = await _RepuestoServicio.ActualizarRepuesto(RepuestoConvert.toEntity(modelo));
            if (Repuesto != null)
            {
                return Ok(RepuestoConvert.toModel(Repuesto));
            }
            else
            {
                ResponseModel response = new ResponseModel()
                {
                    Estado = 200,
                    Mensaje = "No se pudo actualizar el Repuesto"
                };
                return Ok(response);
            }
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> eliminarRepuesto(string id)
        {
            var guid = Guid.Parse(id);
            var resultado = await _RepuestoServicio.EliminarRepuesto(guid);
            if (resultado)
            {
                ResponseModel response = new ResponseModel()
                {
                    Mensaje = "Repuesto eliminado",
                    Estado = 200
                };
                return Ok(response);
            }
            else
            {
                ResponseModel response = new ResponseModel()
                {
                    Mensaje = "Repuesto no se pudo eliminar",
                    Estado = 200
                };
                return Ok(response);
            }
        }
    }
}