using CarCenterData.Entidades.Negocio;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CarCenterCore.Servicios
{
    public interface IMantenimientoServicio
    {
        Task<Mantenimiento> CrearMantenimiento(Mantenimiento modelo);
        Task<Mantenimiento> ObtenerMantenimientoPorId(Guid MantenimientoId);
        Task<List<Mantenimiento>> ObtenerMantenimientos();
        Task<Mantenimiento> ActualizarMantenimiento(Mantenimiento modelo);
        Task<bool> EliminarMantenimiento(Guid MantenimientoId);
    }
}
