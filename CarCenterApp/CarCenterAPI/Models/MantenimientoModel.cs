using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarCenterAPI.Models
{
    public class MantenimientoModel
    {
        public string Id { get; set; }
        public int Estado { get; set; }
        public DateTime Fecha { get; set; }
        public string MecanicoId { get; set; }
        public MecanicoModel Mecanico { get; set; }
        public string VehiculoId { get; set; }
        public VehiculoModel Vehiculo { get; set; }
        public List<FotoModel> Fotos { get; set; }
    }
}
