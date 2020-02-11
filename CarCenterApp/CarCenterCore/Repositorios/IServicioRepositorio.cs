using CarCenterData.Entidades.Negocio;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CarCenterCore.Repositorios
{
    public interface IServicioRepositorio
    {
        Task<Servicio> CrearServicio(Servicio modelo);
        Task<Servicio> ObtenerServicioPorId(Guid ServicioId);
        Task<List<Servicio>> ObtenerServicios();
        Task<Servicio> ActualizarServicio(Servicio modelo);
        Task<bool> EliminarServicio(Guid ServicioId);
    }
}
