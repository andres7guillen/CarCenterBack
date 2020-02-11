using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CarCenterData.Entidades.Negocio
{
    public class Vehiculo
    {
        public Guid Id { get; set; }

        [StringLength(6)]
        public string Placa { get; set; }

        [StringLength(30)]
        public string Color { get; set; }

        public Guid ClienteId { get; set; }
        public Cliente Cliente { get; set; }
        public Guid MarcaId { get; set; }
        public Marca Marca { get; set; }

        public List<Mantenimiento> Mantenimientos { get; set; }


    }
}
