using CarCenterAPI.Models;
using CarCenterData.Entidades.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarCenterAPI.Converts
{
    public static class RepuestoConvert
    {
        public static RepuestoModel toModel(Repuesto input)
        {
            RepuestoModel output = new RepuestoModel();
            output.Id = input.Id != null ? output.Id = input.Id.ToString() : output.Id = "-o-";
            output.Nombre = input.Nombre != null ? output.Nombre = input.Nombre : output.Nombre = "-o-";
            output.PrecioUnitario = input.PrecioUnitario != null ? output.PrecioUnitario = input.PrecioUnitario : output.PrecioUnitario = -1;
            output.Proveedor = input.Proveedor != null ? output.Proveedor = input.Proveedor : output.Proveedor = "-o-";
            output.UnidadesInventario = input.UnidadesInventario != null ? output.UnidadesInventario = input.UnidadesInventario : output.UnidadesInventario = -1;
            return output;
        }

        public static List<RepuestoModel> toListModel(List<Repuesto> input)
        {
            return input.Select(c => toModel(c)).ToList();
        }

        public static Repuesto toEntity(RepuestoModel input)
        {
            Repuesto output = new Repuesto();
            //output.Id = input.Id != null ? output.Id = input.Id.ToString() : output.Id = "-o-";
            output.Nombre = input.Nombre != null ? output.Nombre = input.Nombre : output.Nombre = "-o-";
            output.PrecioUnitario = input.PrecioUnitario != null ? output.PrecioUnitario = input.PrecioUnitario : output.PrecioUnitario = -1;
            output.Proveedor = input.Proveedor != null ? output.Proveedor = input.Proveedor : output.Proveedor = "-o-";
            output.UnidadesInventario = input.UnidadesInventario != null ? output.UnidadesInventario = input.UnidadesInventario : output.UnidadesInventario = -1;
            return output;
        }

        public static List<Repuesto> toListEntity(List<RepuestoModel> input)
        {
            return input.Select(c => toEntity(c)).ToList();
        }

    }
}
