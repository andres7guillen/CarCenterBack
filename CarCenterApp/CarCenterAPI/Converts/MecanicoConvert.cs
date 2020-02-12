using CarCenterAPI.Models;
using CarCenterData.Entidades.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarCenterAPI.Converts
{
    public static class MecanicoConvert
    {
        public static MecanicoModel toModel(Mecanico input)
        {
            MecanicoModel output = new MecanicoModel();
            output.Celular = input.Celular != null ? output.Celular = input.Celular : output.Celular = "-o-";
            output.Direccion = input.Direccion != null ? output.Direccion = input.Direccion : output.Direccion = "-o-";
            output.Documento = input.Documento != null ? output.Documento = input.Documento : output.Documento = "-o-";
            output.Email = input.Email != null ? output.Email = input.Email : output.Email = "-o-";
            output.Id = input.Id != null ? output.Id = input.Id.ToString() : output.Id = "-o-";
            output.Mantenimientos = input.Mantenimientos != null ? output.Mantenimientos = MantenimientoConvert.toListModel(input.Mantenimientos) : output.Mantenimientos = new List<MantenimientoModel>();
            output.PrimerApellido = input.PrimerApellido != null ? output.PrimerApellido = input.PrimerApellido : output.PrimerApellido = "-o-";
            output.PrimerNombre = input.PrimerNombre != null ? output.PrimerNombre = input.PrimerNombre : output.PrimerNombre = "-o-";
            output.SegundoApellido = input.SegundoApellido != null ? output.SegundoApellido = input.SegundoApellido : output.SegundoApellido = "-o-";
            output.SegundoNombre = input.SegundoNombre != null ? output.SegundoNombre = input.SegundoNombre : output.SegundoNombre = "-o-";
            return output;
        }

        public static List<MecanicoModel> toListModel(List<Mecanico> input)
        {
            return input.Select(c => toModel(c)).ToList();
        }

        public static Mecanico toEntity(MecanicoModel input)
        {
            Mecanico output = new Mecanico();
            output.Celular = input.Celular != null ? output.Celular = input.Celular : output.Celular = "-o-";
            output.Direccion = input.Direccion != null ? output.Direccion = input.Direccion : output.Direccion = "-o-";
            output.Documento = input.Documento != null ? output.Documento = input.Documento : output.Documento = "-o-";
            output.Email = input.Email != null ? output.Email = input.Email : output.Email = "-o-";
            //output.Id = input.Id != null ? output.Id = Guid.Parse(input.Id.ToString()) : output.Id = Guid.Empty;
            output.Mantenimientos = input.Mantenimientos != null ? output.Mantenimientos = MantenimientoConvert.toListEntity(input.Mantenimientos) : output.Mantenimientos = new List<Mantenimiento>();
            output.PrimerApellido = input.PrimerApellido != null ? output.PrimerApellido = input.PrimerApellido : output.PrimerApellido = "-o-";
            output.PrimerNombre = input.PrimerNombre != null ? output.PrimerNombre = input.PrimerNombre : output.PrimerNombre = "-o-";
            output.SegundoApellido = input.SegundoApellido != null ? output.SegundoApellido = input.SegundoApellido : output.SegundoApellido = "-o-";
            output.SegundoNombre = input.SegundoNombre != null ? output.SegundoNombre = input.SegundoNombre : output.SegundoNombre = "-o-";
            return output;
        }
    }
}
