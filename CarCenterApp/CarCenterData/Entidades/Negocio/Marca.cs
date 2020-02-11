using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CarCenterData.Entidades.Negocio
{
    public class Marca
    {
        public Guid Id { get; set; }

        [StringLength(30)]
        public string NombreMarca { get; set; }
        public List<Vehiculo> Vehiculos { get; set; }
    }
}
