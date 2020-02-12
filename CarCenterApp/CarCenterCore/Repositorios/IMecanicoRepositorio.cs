using CarCenterData.Entidades.Negocio;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CarCenterCore.Repositorios
{
    public interface IMecanicoRepositorio
    {
        Task<Mecanico> CrearMecanico(Mecanico modelo);
        Task<Mecanico> ObtenerMecanicoPorId(Guid MecanicoId);
        Task<List<Mecanico>> ObtenerMecanicos();
        Task<Mecanico> ActualizarMecanico(Mecanico modelo);
        Task<bool> EliminarMecanico(Guid MecanicoId);
    }
}
