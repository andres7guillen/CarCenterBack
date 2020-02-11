using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CarCenterAPI.Models
{
    public class VehiculoModel
    {
        public string Id { get; set; }

        [StringLength(6)]
        public string Placa { get; set; }

        [StringLength(30)]
        public string Color { get; set; }

        public string ClienteId { get; set; }
        public ClienteModel Cliente { get; set; }
        public string MarcaId { get; set; }
        public MarcaModel Marca { get; set; }

        public List<MantenimientoModel> Mantenimientos { get; set; }
    }
}
