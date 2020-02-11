using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CarCenterAPI.Models
{
    public class ServicioModel
    {
        public string Id { get; set; }

        [StringLength(100)]
        public string Nombre { get; set; }

        public double Precio { get; set; }
    }
}
