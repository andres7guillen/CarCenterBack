using CarCenterAPI.Models;
using CarCenterData.Entidades.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarCenterAPI.Converts
{
    public static class MarcaConvert
    {
        public static MarcaModel toModel(Marca input)
        {
            MarcaModel output = new MarcaModel();
            output.Id = input.Id != null ? output.Id = input.Id.ToString() : output.Id = "-o-";
            output.NombreMarca = input.NombreMarca != null ? output.NombreMarca = input.NombreMarca : output.NombreMarca = "-o-";
            output.Vehiculos = input.Vehiculos != null ? output.Vehiculos = VehiculoConvert.toListModel(input.Vehiculos) : output.Vehiculos = new List<VehiculoModel>();
            return output;
        }

        public static List<MarcaModel> toListModel(List<Marca> input)
        {
            return input.Select(c => toModel(c)).ToList();
        }

        public static Marca toEntity(MarcaModel input)
        {
            Marca output = new Marca();
            output.Id = input.Id != null ? output.Id = Guid.Parse(input.Id.ToString()) : output.Id = Guid.Empty;
            output.NombreMarca = input.NombreMarca != null ? output.NombreMarca = input.NombreMarca : output.NombreMarca = "-o-";
            output.Vehiculos = input.Vehiculos != null ? output.Vehiculos = VehiculoConvert.toListEntity(input.Vehiculos) : output.Vehiculos = new List<Vehiculo>();
            return output;
        }

    }


}

