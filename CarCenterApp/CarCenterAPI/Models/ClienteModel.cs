using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CarCenterAPI.Models
{
    public class ClienteModel
    {
        public string Id { get; set; }

        [StringLength(2)]
        public string TipoDocumento { get; set; }
        [StringLength(20)]
        public string Documento { get; set; }

        [StringLength(30)]
        public string PrimerNombre { get; set; }

        [StringLength(30)]
        public string SegundoNombre { get; set; }

        [StringLength(30)]
        public string PrimerApellido { get; set; }

        [StringLength(30)]
        public string SegundoApellido { get; set; }

        [StringLength(10)]
        public string Celular { get; set; }

        [StringLength(200)]
        public string Direccion { get; set; }

        [StringLength(100)]
        public string Email { get; set; }

        public double PresupuestoMaximo { get; set; }

        public List<VehiculoModel> Vehiculos { get; set; }
    }
}
