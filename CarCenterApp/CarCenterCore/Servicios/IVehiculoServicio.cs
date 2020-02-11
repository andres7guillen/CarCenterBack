using CarCenterData.Entidades.Negocio;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CarCenterCore.Servicios
{
    public interface IVehiculoServicio
    {
        Task<Vehiculo> CrearVehiculo(Vehiculo modelo);
        Task<Vehiculo> ObtenerVehiculoPorId(Guid VehiculoId);
        Task<List<Vehiculo>> ObtenerVehiculos();
        Task<Vehiculo> ActualizarVehiculo(Vehiculo modelo);
        Task<bool> EliminarVehiculo(Guid VehiculoId);
    }
}
