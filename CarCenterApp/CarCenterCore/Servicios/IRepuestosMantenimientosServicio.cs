using CarCenterData.Entidades.Negocio;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CarCenterCore.Servicios
{
    public interface IRepuestosMantenimientosServicio
    {
        Task<List<RepuestosMantenimientos>> ObtenerRepuestosPorMantenimientoId(Guid MantenimientoId);
    }
}
