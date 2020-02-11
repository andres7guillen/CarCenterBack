using CarCenterAPI.Models;
using CarCenterData.Entidades.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarCenterAPI.Converts
{
    public static class VehiculoConvert
    {
        public static VehiculoModel toVehiculoModel(Vehiculo input)
        {
            VehiculoModel output = new VehiculoModel();
            output.Cliente = input.Cliente != null ? output.Cliente = ClienteConvert.toClienteModel(input.Cliente) : output.Cliente = null;
            output.ClienteId = input.ClienteId != null ? output.ClienteId = input.ClienteId.ToString() : output.ClienteId = "-o-";
            output.Color = input.Color != null ? output.Color = input.Color : output.Color = "-o-";
            output.Id = input.Id != null ? output.Id = input.Id.ToString() : output.Id = "-o-";
            output.Mantenimientos = input.Mantenimientos != null ? output.Mantenimientos = MantenimientoConvert.toListModel(input.Mantenimientos) : output.Mantenimientos = new List<MantenimientoModel>();
            output.Marca = input.Marca != null ? output.Marca = MarcaConvert.toModel(input.Marca) : output.Marca = new MarcaModel();
            output.MarcaId = input.MarcaId != null ? output.MarcaId = input.MarcaId.ToString() : output.MarcaId = "-o-";
            output.Placa = input.Placa != null ? output.Placa = input.Placa : output.Placa = "-o-";
            return output;
        }

        public static List<VehiculoModel> toListModel(List<Vehiculo> input)
        {
            return input.Select(c => toVehiculoModel(c)).ToList();
        }

        public static Vehiculo toEntity(VehiculoModel input)
        {
            Vehiculo output = new Vehiculo();
            output.Cliente = input.Cliente != null ? output.Cliente = ClienteConvert.toEntity(input.Cliente) : output.Cliente = null;
            output.ClienteId = input.ClienteId != null ? output.ClienteId = Guid.Parse(input.ClienteId.ToString()) : Guid.Empty;
            output.Color = input.Color != null ? output.Color = input.Color : output.Color = "-o-";
            output.Id = input.Id != null ? output.Id = Guid.Parse(input.Id.ToString()) : output.Id = Guid.Empty;
            output.Mantenimientos = input.Mantenimientos != null ? output.Mantenimientos = MantenimientoConvert.toListEntity(input.Mantenimientos) : output.Mantenimientos = new List<Mantenimiento>();
            output.Marca = input.Marca != null ? output.Marca = MarcaConvert.toEntity(input.Marca) : output.Marca = new Marca();
            output.MarcaId = input.MarcaId != null ? output.MarcaId = Guid.Parse(input.MarcaId.ToString()) : output.MarcaId = Guid.Empty;
            output.Placa = input.Placa != null ? output.Placa = input.Placa : output.Placa = "-o-";
            return output;
        }

        public static List<Vehiculo> toListEntity(List<VehiculoModel> input)
        {
            return input.Select(c => toEntity(c)).ToList();
        }


    }
}
