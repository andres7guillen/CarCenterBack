using CarCenterCore.Repositorios;
using CarCenterCore.Servicios;
using CarCenterData.Entidades.Negocio;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CarCenterInfrastructure.Servicios
{
    public class MecanicoServicio : IMecanicoServicio
    {
        private readonly IMecanicoRepositorio _repositorio;
        public MecanicoServicio(IMecanicoRepositorio repositorio)
        {
            _repositorio = repositorio;
        }


        public async Task<Mecanico> ActualizarMecanico(Mecanico modelo) => await _repositorio.ActualizarMecanico(modelo);

        public async Task<Mecanico> CrearMecanico(Mecanico modelo) => await _repositorio.CrearMecanico(modelo);

        public async Task<bool> EliminarMecanico(Guid MecanicoId) => await _repositorio.EliminarMecanico(MecanicoId);

        public async Task<Mecanico> ObtenerMecanicoPorId(Guid MecanicoId) => await _repositorio.ObtenerMecanicoPorId(MecanicoId);

        public async Task<List<Mecanico>> ObtenerMecanicos() => await _repositorio.ObtenerMecanicos();
    }
}
