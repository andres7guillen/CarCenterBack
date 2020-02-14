using CarCenterCore.Repositorios;
using CarCenterCore.Servicios;
using CarCenterData.Entidades.Negocio;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CarCenterInfrastructure.Servicios
{
    public class MantenimientoServicio : IMantenimientoServicio
    {
        private readonly IMantenimientoRepositorio _repositorio;
        public MantenimientoServicio(IMantenimientoRepositorio repositorio)
        {
            _repositorio = repositorio;
        }


        public async Task<Mantenimiento> ActualizarMantenimiento(Mantenimiento modelo) => await _repositorio.ActualizarMantenimiento(modelo);

        public async Task<Mantenimiento> CrearMantenimiento(Mantenimiento modelo) => await _repositorio.CrearMantenimiento(modelo);

        public async Task<bool> EliminarMantenimiento(Guid MantenimientoId) => await _repositorio.EliminarMantenimiento(MantenimientoId);

        public async Task<Mantenimiento> ObtenerMantenimientoPorId(Guid MantenimientoId) => await _repositorio.ObtenerMantenimientoPorId(MantenimientoId);

        public async Task<List<Mantenimiento>> ObtenerMantenimientos() => await _repositorio.ObtenerMantenimientos();

        public async Task<List<Mantenimiento>> ObtenerMantenimientosPorClienteId(Guid ClienteId) => await _repositorio.ObtenerMantenimientosPorClienteId(ClienteId);
    }
}
