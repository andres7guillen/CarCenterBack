using CarCenterData.Entidades.Negocio;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CarCenterCore.Servicios
{
    public interface IMarcaServicio
    {
        Task<Marca> CrearMarca(Marca modelo);
        Task<Marca> ObtenerMarcaPorId(Guid MarcaId);
        Task<List<Marca>> ObtenerMarcas();
        Task<Marca> ActualizarMarca(Marca modelo);
        Task<bool> EliminarMarca(Guid MarcaId);
    }
}
