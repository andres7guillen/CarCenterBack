using CarCenterData.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CarCenterCore.Servicios
{
    public interface IFacturaServicio
    {
        Task<FacturaDTO> generarFactura(Guid ClienteId);
    }
}
