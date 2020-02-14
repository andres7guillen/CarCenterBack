using CarCenterData.Entidades.Negocio;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CarCenterCore.Servicios
{
    public interface IServiciosMantenimientosServicio
    {
        Task<List<ServiciosMantenimientos>> obtenerServiciosPorMantenimiento(Guid MantenimientoId);
    }
}
