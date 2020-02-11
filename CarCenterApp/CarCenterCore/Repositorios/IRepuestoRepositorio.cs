using CarCenterData.Entidades.Negocio;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CarCenterCore.Repositorios
{
    public interface IRepuestoRepositorio
    {
        Task<Repuesto> CrearRepuesto(Repuesto modelo);
        Task<Repuesto> ObtenerRepuestoPorId(Guid RepuestoId);
        Task<List<Repuesto>> ObtenerRepuestos();
        Task<Repuesto> ActualizarRepuesto(Repuesto modelo);
        Task<bool> EliminarRepuesto(Guid RepuestoId);
    }
}
