using System;
using System.Collections.Generic;
using System.Text;

namespace CarCenterData.Entidades.Negocio
{
    public class RepuestosMantenimientos
    {
        public Guid RepuestoId { get; set; }
        public Repuesto Repuesto { get; set; }
        public Guid MantenimientoId { get; set; }
        public Mantenimiento Mantenimiento { get; set; }
    }
}
