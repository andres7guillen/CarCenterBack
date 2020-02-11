using CarCenterCore.Repositorios;
using CarCenterCore.Servicios;
using CarCenterData.Entidades.Negocio;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CarCenterInfrastructure.Servicios
{
    public class VehiculoServicio : IVehiculoServicio
    {
        private readonly IVehiculoRepositorio _repositorio;
        public VehiculoServicio(IVehiculoRepositorio repositorio)
        {
            _repositorio = repositorio;
        }


        public async Task<Vehiculo> ActualizarVehiculo(Vehiculo modelo) => await _repositorio.ActualizarVehiculo(modelo);

        public async Task<Vehiculo> CrearVehiculo(Vehiculo modelo) => await _repositorio.CrearVehiculo(modelo);

        public async Task<bool> EliminarVehiculo(Guid VehiculoId) => await _repositorio.EliminarVehiculo(VehiculoId);

        public async Task<Vehiculo> ObtenerVehiculoPorId(Guid VehiculoId) => await _repositorio.ObtenerVehiculoPorId(VehiculoId);

        public async Task<List<Vehiculo>> ObtenerVehiculos() => await _repositorio.ObtenerVehiculos();
    }
}
