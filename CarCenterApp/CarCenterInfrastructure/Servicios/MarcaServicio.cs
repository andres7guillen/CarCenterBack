using CarCenterCore.Repositorios;
using CarCenterCore.Servicios;
using CarCenterData.Entidades.Negocio;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CarCenterInfrastructure.Servicios
{
    public class MarcaServicio : IMarcaServicio
    {
        private readonly IMarcaRepositorio _repositorio;
        public MarcaServicio(IMarcaRepositorio repositorio)
        {
            _repositorio = repositorio;
        }


        public async Task<Marca> ActualizarMarca(Marca modelo) => await _repositorio.ActualizarMarca(modelo);

        public async Task<Marca> CrearMarca(Marca modelo) => await _repositorio.CrearMarca(modelo);

        public async Task<bool> EliminarMarca(Guid MarcaId) => await _repositorio.EliminarMarca(MarcaId);

        public async Task<Marca> ObtenerMarcaPorId(Guid MarcaId) => await _repositorio.ObtenerMarcaPorId(MarcaId);

        public async Task<List<Marca>> ObtenerMarcas() => await _repositorio.ObtenerMarcas();
    }
}
