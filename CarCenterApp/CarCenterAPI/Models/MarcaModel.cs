using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CarCenterAPI.Models
{
    public class MarcaModel
    {
        public string Id { get; set; }

        [StringLength(30)]
        public string NombreMarca { get; set; }
        public List<VehiculoModel> Vehiculos { get; set; }
    }
}
