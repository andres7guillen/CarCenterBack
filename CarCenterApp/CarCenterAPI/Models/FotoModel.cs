using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CarCenterAPI.Models
{
    public class FotoModel
    {
        public string Id { get; set; }
        [StringLength(200)]
        public string Ruta { get; set; }

        public string MantenimientoId { get; set; }
        public MantenimientoModel Mantenimiento { get; set; }
    }
}
