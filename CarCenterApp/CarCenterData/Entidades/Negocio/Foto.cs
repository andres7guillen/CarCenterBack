using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CarCenterData.Entidades.Negocio
{
    public class Foto
    {
        public Guid Id { get; set; }
        [StringLength(200)]
        public string Ruta { get; set; }

        public Guid MantenimientoId { get; set; }
        public Mantenimiento Mantenimiento { get; set; }
    }
}
