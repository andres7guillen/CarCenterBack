using CarCenterCore.Repositorios;
using CarCenterCore.Servicios;
using CarCenterData.Entidades.Negocio;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CarCenterInfrastructure.Servicios
{
    public class ClienteServicio : IClienteServicio
    {
        private readonly IClienteRepositorio _repositorio;
        public ClienteServicio(IClienteRepositorio repositorio)
        {
            _repositorio = repositorio;
        }


        public async Task<Cliente> ActualizarCliente(Cliente modelo) => await _repositorio.ActualizarCliente(modelo);

        public async Task<Cliente> CrearCliente(Cliente modelo) => await _repositorio.CrearCliente(modelo);

        public async Task<bool> EliminarCliente(Guid ClienteId) => await _repositorio.EliminarCliente(ClienteId);

        public async Task<Cliente> ObtenerClientePorId(Guid ClienteId) => await _repositorio.ObtenerClientePorId(ClienteId);

        public async Task<List<Cliente>> ObtenerClientes() => await _repositorio.ObtenerClientes();
    }
}
