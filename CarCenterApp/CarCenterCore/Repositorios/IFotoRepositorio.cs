using CarCenterData.Entidades.Negocio;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CarCenterCore.Repositorios
{
    public interface IFotoRepositorio
    {
        Task<Foto> CrearFoto(Foto modelo);
        Task<Foto> ObtenerFotoPorId(Guid FotoId);
        Task<List<Foto>> ObtenerFotos();
        Task<Foto> ActualizarFoto(Foto modelo);
        Task<bool> EliminarFoto(Guid FotoId);
    }
}
