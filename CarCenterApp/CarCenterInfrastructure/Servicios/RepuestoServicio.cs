using CarCenterCore.Repositorios;
using CarCenterCore.Servicios;
using CarCenterData.Entidades.Negocio;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CarCenterInfrastructure.Servicios
{
    public class RepuestoServicio : IRepuestoServicio
    {
        private readonly IRepuestoRepositorio _repositorio;
        public RepuestoServicio(IRepuestoRepositorio repositorio)
        {
            _repositorio = repositorio;
        }


        public async Task<Repuesto> ActualizarRepuesto(Repuesto modelo) => await _repositorio.ActualizarRepuesto(modelo);

        public async Task<Repuesto> CrearRepuesto(Repuesto modelo) => await _repositorio.CrearRepuesto(modelo);

        public async Task<bool> EliminarRepuesto(Guid RepuestoId) => await _repositorio.EliminarRepuesto(RepuestoId);

        public async Task<Repuesto> ObtenerRepuestoPorId(Guid RepuestoId) => await _repositorio.ObtenerRepuestoPorId(RepuestoId);

        public async Task<List<Repuesto>> ObtenerRepuestos() => await _repositorio.ObtenerRepuestos();
    }
}
