using CarCenterCore.Repositorios;
using CarCenterCore.Servicios;
using CarCenterData.Entidades.Negocio;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CarCenterInfrastructure.Servicios
{
    public class ServicioServicio : IServicioServicio
    {
        private readonly IServicioRepositorio _repositorio;
        public ServicioServicio(IServicioRepositorio repositorio)
        {
            _repositorio = repositorio;
        }


        public async Task<Servicio> ActualizarServicio(Servicio modelo) => await _repositorio.ActualizarServicio(modelo);

        public async Task<Servicio> CrearServicio(Servicio modelo) => await _repositorio.CrearServicio(modelo);

        public async Task<bool> EliminarServicio(Guid ServicioId) => await _repositorio.EliminarServicio(ServicioId);

        public async Task<Servicio> ObtenerServicioPorId(Guid ServicioId) => await _repositorio.ObtenerServicioPorId(ServicioId);

        public async Task<List<Servicio>> ObtenerServicios() => await _repositorio.ObtenerServicios();
    }
}
