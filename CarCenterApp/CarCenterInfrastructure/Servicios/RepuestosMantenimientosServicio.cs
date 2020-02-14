using CarCenterCore.Repositorios;
using CarCenterCore.Servicios;
using CarCenterData.Entidades.Negocio;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CarCenterInfrastructure.Servicios
{
    public class RepuestosMantenimientosServicio : IRepuestosMantenimientosServicio
    {
        private readonly IRepuestosMantenimientosRepositorio _repuestosMantenimientosRepositorio;

        public RepuestosMantenimientosServicio(IRepuestosMantenimientosRepositorio repuestosMantenimientosRepositorio)
        {
            _repuestosMantenimientosRepositorio = repuestosMantenimientosRepositorio;
        }
        public async Task<List<RepuestosMantenimientos>> ObtenerRepuestosPorMantenimientoId(Guid MantenimientoId) => await _repuestosMantenimientosRepositorio.ObtenerRepuestosPorMantenimientoId(MantenimientoId);
    }
}
