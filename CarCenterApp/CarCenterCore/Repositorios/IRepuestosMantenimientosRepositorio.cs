using CarCenterData.Entidades.Negocio;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CarCenterCore.Repositorios
{
    public interface IRepuestosMantenimientosRepositorio
    {
        Task<List<RepuestosMantenimientos>> ObtenerRepuestosPorMantenimientoId(Guid MantenimientoId);
    }
}
