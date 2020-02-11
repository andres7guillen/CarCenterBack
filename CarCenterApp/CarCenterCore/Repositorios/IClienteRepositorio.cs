using CarCenterData.Entidades.Negocio;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CarCenterCore.Repositorios
{
    public interface IClienteRepositorio
    {
        Task<Cliente> CrearCliente(Cliente modelo);
        Task<Cliente> ObtenerClientePorId(Guid ClienteId);
        Task<List<Cliente>> ObtenerClientes();
        Task<Cliente> ActualizarCliente(Cliente modelo);
        Task<bool> EliminarCliente(Guid ClienteId);
    }
}
