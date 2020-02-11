using CarCenterCore.Repositorios;
using CarCenterCore.Servicios;
using CarCenterData.Entidades.Negocio;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CarCenterInfrastructure.Servicios
{
    public class FotoServicio : IFotoServicio
    {
        private readonly IFotoRepositorio _repositorio;
        public FotoServicio(IFotoRepositorio repositorio)
        {
            _repositorio = repositorio;
        }


        public async Task<Foto> ActualizarFoto(Foto modelo) => await _repositorio.ActualizarFoto(modelo);

        public async Task<Foto> CrearFoto(Foto modelo) => await _repositorio.CrearFoto(modelo);

        public async Task<bool> EliminarFoto(Guid FotoId) => await _repositorio.EliminarFoto(FotoId);

        public async Task<Foto> ObtenerFotoPorId(Guid FotoId) => await _repositorio.ObtenerFotoPorId(FotoId);

        public async Task<List<Foto>> ObtenerFotos() => await _repositorio.ObtenerFotos();
    }
}
