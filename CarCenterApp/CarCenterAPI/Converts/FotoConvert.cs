using CarCenterAPI.Models;
using CarCenterData.Entidades.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarCenterAPI.Converts
{
    public static class FotoConvert
    {
        public static FotoModel toModel(Foto input)
        {
            FotoModel output = new FotoModel();
            output.Id = input.Id != null ? output.Id = input.Id.ToString() : output.Id = "";
            output.Mantenimiento = input.Mantenimiento != null ? output.Mantenimiento = MantenimientoConvert.toModel(input.Mantenimiento) : output.Mantenimiento = null;
            output.MantenimientoId = input.MantenimientoId != null ? output.MantenimientoId = input.MantenimientoId.ToString() : output.MantenimientoId = "-o-";
            output.Ruta = input.Ruta != null ? output.Ruta = input.Ruta : output.Ruta = "-o-";
            return output;
        }

        public static List<FotoModel> toListModel(List<Foto> input)
        {
            return input.Select(f => toModel(f)).ToList();
        }

        public static Foto toEntity(FotoModel input)
        {
            Foto output = new Foto();
            output.Id = input.Id != null ? output.Id = Guid.Parse(input.Id.ToString()) : output.Id = Guid.Empty;
            output.Mantenimiento = input.Mantenimiento != null ? output.Mantenimiento = MantenimientoConvert.toEntity(input.Mantenimiento) : output.Mantenimiento = new Mantenimiento();
            output.MantenimientoId = input.MantenimientoId != null ? output.MantenimientoId = Guid.Parse(input.MantenimientoId.ToString()) : output.MantenimientoId = Guid.Empty;
            output.Ruta = input.Ruta != null ? output.Ruta = input.Ruta : output.Ruta = "-o-";
            return output;
        }

        public static List<Foto> toListEntity(List<FotoModel> input)
        {
            return input.Select(c => toEntity(c)).ToList();
        }
    }
}
