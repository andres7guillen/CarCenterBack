using System;
using System.Collections.Generic;
using System.Text;

namespace CarCenterData.Entidades.Negocio
{
    public class ServiciosMantenimientos
    {
        public Guid ServicioId { get; set; }
        public Servicio Servicio { get; set; }
        public Guid MantenimientoId { get; set; }
        public Mantenimiento Mantenimiento { get; set; }
    }
}
