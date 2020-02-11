using System;
using System.Collections.Generic;
using System.Text;

namespace CarCenterData.Entidades.Negocio
{
    public class Mantenimiento
    {
        public Guid Id { get; set; }
        public int Estado { get; set; }        
        public DateTime Fecha { get; set; }
        public Guid MecanicoId { get; set; }
        public Mecanico Mecanico { get; set; }
        public Guid VehiculoId { get; set; }
        public Vehiculo Vehiculo { get; set; }
        public List<Foto> Fotos { get; set; }

    }
}
