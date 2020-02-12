using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CarCenterAPI.Models
{
    public class RepuestoModel
    {
        public string Id { get; set; }

        [StringLength(100)]
        public string Nombre { get; set; }

        public double PrecioUnitario { get; set; }
        public int UnidadesInventario { get; set; }
        [StringLength(300)]
        public string Proveedor { get; set; }
    }
}
