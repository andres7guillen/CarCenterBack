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
    public class ClienteController : ControllerBase
    {
        private readonly IClienteServicio _clienteServicio;

        public ClienteController(IClienteServicio clienteServicio)
        {
            _clienteServicio = clienteServicio;
        }

        [HttpPost("Crear")]
        public async Task<IActionResult> Crear([FromBody]ClienteModel model)
        {
            var cliente = await _clienteServicio.CrearCliente(ClienteConvert.toEntity(model));
            if (cliente != null)
            {
                return Ok(ClienteConvert.toClienteModel(cliente));
            }
            else
            {
                ResponseModel response = new ResponseModel()
                {
                    Mensaje = "No se pudo crear el cliente",
                    Estado = 200
                };
                return Ok(response);
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> ObtenerPorId(string id)
        {
            var guid = Guid.Parse(id);
            var cliente = await _clienteServicio.ObtenerClientePorId(guid);
            if (cliente == null) { return NotFound(); } else { return Ok(ClienteConvert.toClienteModel(cliente)); }
        }

        [HttpGet]
        public async Task<IActionResult> obtenerTodos()
        {
            var resultado = await _clienteServicio.ObtenerClientes();
            if (resultado.Count() >= 1) { return Ok(ClienteConvert.toListModel(resultado)); }
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
        public async Task<IActionResult> actualizar([FromBody]ClienteModel modelo)
        {
            var cliente = await _clienteServicio.ActualizarCliente(ClienteConvert.toEntity(modelo));
            if (cliente != null)
            {
                return Ok(ClienteConvert.toClienteModel(cliente));
            }
            else
            {
                ResponseModel response = new ResponseModel()
                {
                    Estado = 200,
                    Mensaje = "No se pudo actualizar el cliente"
                };
                return Ok(response);
            }
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> eliminarCliente(string id)
        {
            var guid = Guid.Parse(id);
            var resultado = await _clienteServicio.EliminarCliente(guid);
            if (resultado)
            {
                ResponseModel response = new ResponseModel()
                {
                    Mensaje = "Cliente eliminado",
                    Estado = 200
                };
                return Ok(response);
            }
            else
            {
                ResponseModel response = new ResponseModel()
                {
                    Mensaje = "Cliente no se pudo eliminar",
                    Estado = 200
                };
                return Ok(response);
            }
        }


    }
}