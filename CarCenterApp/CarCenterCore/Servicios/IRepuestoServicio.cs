using CarCenterData.Entidades.Negocio;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CarCenterCore.Servicios
{
    public interface IRepuestoServicio
    {
        Task<Repuesto> CrearRepuesto(Repuesto modelo);
        Task<Repuesto> ObtenerRepuestoPorId(Guid RepuestoId);
        Task<List<Repuesto>> ObtenerRepuestos();
        Task<Repuesto> ActualizarRepuesto(Repuesto modelo);
        Task<bool> EliminarRepuesto(Guid RepuestoId);
    }
}
