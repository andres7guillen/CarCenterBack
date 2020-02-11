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
    public class VehiculoController : ControllerBase
    {
        private readonly IVehiculoServicio _vehiculoServicio;
        public VehiculoController(IVehiculoServicio vehiculoServicio)
        {
            _vehiculoServicio = vehiculoServicio;
        }

        [HttpPost("Crear")]
        public async Task<IActionResult> Crear([FromBody]VehiculoModel model)
        {
            var Vehiculo = await _vehiculoServicio.CrearVehiculo(VehiculoConvert.toEntity(model));
            if (Vehiculo != null)
            {
                return Ok(VehiculoConvert.toVehiculoModel(Vehiculo));
            }
            else
            {
                ResponseModel response = new ResponseModel()
                {
                    Mensaje = "No se pudo crear el Vehiculo",
                    Estado = 200
                };
                return Ok(response);
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> ObtenerPorId(string id)
        {
            var guid = Guid.Parse(id);
            var Vehiculo = await _vehiculoServicio.ObtenerVehiculoPorId(guid);
            if (Vehiculo == null) { return NotFound(); } else { return Ok(VehiculoConvert.toVehiculoModel(Vehiculo)); }
        }

        [HttpGet]
        public async Task<IActionResult> obtenerTodos()
        {
            var resultado = await _vehiculoServicio.ObtenerVehiculos();
            if (resultado.Count() >= 1) { return Ok(VehiculoConvert.toListModel(resultado)); }
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
        public async Task<IActionResult> actualizar([FromBody]VehiculoModel modelo)
        {
            var Vehiculo = await _vehiculoServicio.ActualizarVehiculo(VehiculoConvert.toEntity(modelo));
            if (Vehiculo != null)
            {
                return Ok(VehiculoConvert.toVehiculoModel(Vehiculo));
            }
            else
            {
                ResponseModel response = new ResponseModel()
                {
                    Estado = 200,
                    Mensaje = "No se pudo actualizar el Vehiculo"
                };
                return Ok(response);
            }
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> eliminarVehiculo(string id)
        {
            var guid = Guid.Parse(id);
            var resultado = await _vehiculoServicio.EliminarVehiculo(guid);
            if (resultado)
            {
                ResponseModel response = new ResponseModel()
                {
                    Mensaje = "Vehiculo eliminado",
                    Estado = 200
                };
                return Ok(response);
            }
            else
            {
                ResponseModel response = new ResponseModel()
                {
                    Mensaje = "Vehiculo no se pudo eliminar",
                    Estado = 200
                };
                return Ok(response);
            }
        }

    }
}