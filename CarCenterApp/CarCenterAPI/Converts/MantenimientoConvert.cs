using CarCenterAPI.Models;
using CarCenterData.Entidades.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarCenterAPI.Converts
{
    public static class MantenimientoConvert
    {
        public static MantenimientoModel toModel(Mantenimiento input)
        {
            MantenimientoModel output = new MantenimientoModel();
            output.Estado = input.Estado != null ? output.Estado = input.Estado : output.Estado = -1;
            output.Fecha = input.Fecha != null ? output.Fecha = input.Fecha : output.Fecha = new DateTime(0, 0, 0);
            output.Fotos = input.Fotos != null ? output.Fotos = FotoConvert.toListModel(input.Fotos) : output.Fotos = new List<FotoModel>();
            output.Id = input.Id != null ? output.Id = input.Id.ToString() : output.Id = "-o-";
            output.Mecanico = input.Mecanico != null ? output.Mecanico = MecanicoConvert.toModel(input.Mecanico) : output.Mecanico = new MecanicoModel();
            output.MecanicoId = input.MecanicoId != null ? output.MecanicoId = input.MecanicoId.ToString() : output.MecanicoId = "-o-";
            output.Vehiculo = input.Vehiculo != null ? output.Vehiculo = VehiculoConvert.toVehiculoModel(input.Vehiculo) : output.Vehiculo = new VehiculoModel();
            output.VehiculoId = input.VehiculoId != null ? output.VehiculoId = input.VehiculoId.ToString() : output.VehiculoId = "-o-";
            return output;
        }

        public static List<MantenimientoModel> toListModel(List<Mantenimiento> input)
        {
            return input.Select(c => toModel(c)).ToList();
        }

        public static Mantenimiento toEntity(MantenimientoModel input)
        {
            Mantenimiento output = new Mantenimiento();
            output.Estado = input.Estado != null ? output.Estado = input.Estado : output.Estado = -1;
            output.Fecha = input.Fecha != null ? output.Fecha = input.Fecha : output.Fecha = new DateTime(0, 0, 0);
            output.Fotos = input.Fotos != null ? output.Fotos = FotoConvert.toListEntity(input.Fotos) : output.Fotos = new List<Foto>();
            output.Id = input.Id != null ? output.Id = Guid.Parse(input.Id.ToString()) : output.Id = Guid.Empty;
            output.Mecanico = input.Mecanico != null ? output.Mecanico = MecanicoConvert.toEntity(input.Mecanico) : output.Mecanico = new Mecanico();
            output.MecanicoId = input.MecanicoId != null ? output.MecanicoId = Guid.Parse(input.MecanicoId.ToString()) : output.MecanicoId = Guid.Empty;
            output.Vehiculo = input.Vehiculo != null ? output.Vehiculo = VehiculoConvert.toEntity(input.Vehiculo) : output.Vehiculo = new Vehiculo();
            output.VehiculoId = input.VehiculoId != null ? output.VehiculoId = Guid.Parse(input.VehiculoId.ToString()) : output.VehiculoId = Guid.Empty;
            return output;
        }

        public static List<Mantenimiento> toListEntity(List<MantenimientoModel> input)
        {
            return input.Select(c => toEntity(c)).ToList();
        }
    }
}
