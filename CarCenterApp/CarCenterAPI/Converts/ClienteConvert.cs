using CarCenterAPI.Models;
using CarCenterData.Entidades.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarCenterAPI.Converts
{
    public static class ClienteConvert
    {
        public static ClienteModel toClienteModel(Cliente input)
        {
            ClienteModel output = new ClienteModel();
            output.Celular = input.Celular != null ?  output.Celular = input.Celular : output.Celular = "";
            output.Direccion = input.Direccion != null ? output.Direccion = input.Direccion : output.Direccion = "";
            output.Documento = input.Documento != null ? output.Documento = input.Documento : output.Documento = "";
            output.Email = input.Email != null ? output.Email = input.Email : output.Email = "";
            output.Id = input.Id != null ? output.Id = input.Id.ToString() : output.Id = "";
            output.PresupuestoMaximo = input.PresupuestoMaximo != null ? output.PresupuestoMaximo = input.PresupuestoMaximo : output.PresupuestoMaximo = 0;
            output.PrimerApellido = input.PrimerApellido != null ? output.PrimerApellido = input.PrimerApellido : output.PrimerApellido = "";
            output.PrimerNombre = input.PrimerNombre != null ? output.PrimerNombre = input.PrimerNombre : output.PrimerNombre = "";
            output.SegundoApellido = input.SegundoApellido != null ? output.SegundoApellido = input.SegundoApellido : output.SegundoApellido = "";
            output.SegundoNombre = input.SegundoNombre != null ? output.SegundoNombre = input.SegundoNombre : output.SegundoNombre = "";
            output.TipoDocumento = input.TipoDocumento != null ? output.TipoDocumento = input.TipoDocumento : output.TipoDocumento = "";
            output.Vehiculos = input.Vehiculos != null ? output.Vehiculos = VehiculoConvert.toListModel(input.Vehiculos) : output.Vehiculos = new List<VehiculoModel>();
            return output;            
        }

        public static List<ClienteModel> toListModel(List<Cliente> input)
        {
            return input.Select(c => toClienteModel(c)).ToList();
        }

        public static Cliente toEntity(ClienteModel input)
        {
            Cliente output = new Cliente();
            output.Celular = input.Celular != null ? output.Celular = input.Celular : output.Celular = "";
            output.Direccion = input.Direccion != null ? output.Direccion = input.Direccion : output.Direccion = "";
            output.Documento = input.Documento != null ? output.Documento = input.Documento : output.Documento = "";
            output.Email = input.Email != null ? output.Email = input.Email : output.Email = "";
            output.Id = input.Id != null ? output.Id = Guid.Parse(input.Id.ToString()) : output.Id = Guid.NewGuid();
            output.PresupuestoMaximo = input.PresupuestoMaximo != null ? output.PresupuestoMaximo = input.PresupuestoMaximo : output.PresupuestoMaximo = 0;
            output.PrimerApellido = input.PrimerApellido != null ? output.PrimerApellido = input.PrimerApellido : output.PrimerApellido = "";
            output.PrimerNombre = input.PrimerNombre != null ? output.PrimerNombre = input.PrimerNombre : output.PrimerNombre = "";
            output.SegundoApellido = input.SegundoApellido != null ? output.SegundoApellido = input.SegundoApellido : output.SegundoApellido = "";
            output.SegundoNombre = input.SegundoNombre != null ? output.SegundoNombre = input.SegundoNombre : output.SegundoNombre = "";
            output.TipoDocumento = input.TipoDocumento != null ? output.TipoDocumento = input.TipoDocumento : output.TipoDocumento = "";
            output.Vehiculos = input.Vehiculos != null ? output.Vehiculos = VehiculoConvert.toListEntity(input.Vehiculos) : output.Vehiculos = new List<Vehiculo>();
            return output;
        }
    }
}
