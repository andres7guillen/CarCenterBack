using CarCenterData.Entidades.Negocio;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarCenterData.DTO
{
    public class FacturaDTO
    {
        public Guid Id { get; set; }
        public Guid ClienteId { get; set; }
        public Cliente Cliente { get; set; }
        public List<Mantenimiento> Mantenimientos { get; set; }
        public List<RepuestosMantenimientos> Repuestos { get; set; }
        public List<ServiciosMantenimientos> ServiciosMantenimientos { get; set; }
        public Double TotalRepuestos { get; set; }
        public double TotalServicios { get; set; }
        public double TotalSinIva { get; set; }
        public double TotalConIva { get; set; }

    }
}
