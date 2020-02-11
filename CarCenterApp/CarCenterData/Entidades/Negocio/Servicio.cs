using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CarCenterData.Entidades.Negocio
{
    public class Servicio
    {
        public Guid Id { get; set; }

        [StringLength(100)]
        public string Nombre { get; set; }

        public double Precio { get; set; }
    }
}
