using CarCenterAPI.Models;
using CarCenterData.Entidades.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarCenterAPI.Converts
{
    public static class ServicioConvert
    {
        public static ServicioModel toModel(Servicio input)
        {
            ServicioModel output = new ServicioModel();
            output.Id = input.Id != null ? output.Id = input.Id.ToString() : output.Id = "-o-";
            output.Nombre = input.Nombre != null ? output.Nombre = input.Nombre : output.Id = "-o-";
            output.Precio = input.Precio != null ? output.Precio = input.Precio : output.Precio = -1;

            return output;
        }

        public static Servicio toEntity(ServicioModel input)
        {
            Servicio output = new Servicio();
            //output.Id = input.Id != null ? output.Id = Guid.Parse(input.Id.ToString()) : output.Id = 
            output.Nombre = input.Nombre != null ? output.Nombre = input.Nombre : output.Nombre = "-o-";
            output.Precio = input.Precio != null ? output.Precio = input.Precio : output.Precio = -1;

            return output;
        }

        public static List<ServicioModel> toListModel(List<Servicio> input)
        {
            return input.Select(c => toModel(c)).ToList();
        }

        public static List<Servicio> toListEntity(List<ServicioModel> input)
        {
            return input.Select(c => toEntity(c)).ToList();
        }



    }
}
