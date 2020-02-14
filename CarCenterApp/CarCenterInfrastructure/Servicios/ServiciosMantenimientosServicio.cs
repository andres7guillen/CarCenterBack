using CarCenterCore.Repositorios;
using CarCenterCore.Servicios;
using CarCenterData.Entidades.Negocio;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CarCenterInfrastructure.Servicios
{
    public class ServiciosMantenimientosServicio : IServiciosMantenimientosServicio
    {
        private readonly IServiciosMantenimientosRepositorio _serviciosMantenimientosRepositorio;

        public ServiciosMantenimientosServicio(IServiciosMantenimientosRepositorio serviciosMantenimientosRepositorio)
        {
            _serviciosMantenimientosRepositorio = serviciosMantenimientosRepositorio;
        }
        public async Task<List<ServiciosMantenimientos>> obtenerServiciosPorMantenimiento(Guid MantenimientoId) => await _serviciosMantenimientosRepositorio.obtenerServiciosPorMantenimiento(MantenimientoId);
    }
}
