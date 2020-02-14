using CarCenterCore.Repositorios;
using CarCenterCore.Servicios;
using CarCenterData.DTO;
using CarCenterData.Entidades.Negocio;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CarCenterInfrastructure.Servicios
{
    public class FacturaServicio : IFacturaServicio
    {
        private readonly IMantenimientoServicio _mantenimientoServicio;
        private readonly IRepuestosMantenimientosServicio _repuestosMantenimientosServicio;
        private readonly IServiciosMantenimientosServicio _serviciosMantenimientosServicio;
        private readonly IClienteServicio _clienteServicio;



        public FacturaServicio(IMantenimientoServicio mantenimientoServicio, 
            IRepuestosMantenimientosServicio repuestosMantenimientosServicio,
            IServiciosMantenimientosServicio serviciosMantenimientosServicio,
            IClienteServicio clienteServicio)
        {
            _repuestosMantenimientosServicio = repuestosMantenimientosServicio;
            _mantenimientoServicio = mantenimientoServicio;
            _serviciosMantenimientosServicio = serviciosMantenimientosServicio;
            _clienteServicio = clienteServicio;
        }

        public async Task<FacturaDTO> generarFactura(Guid ClienteId)
        {
            Cliente cliente = await _clienteServicio.ObtenerClientePorId(ClienteId);
            FacturaDTO factura = new FacturaDTO();
            factura.Mantenimientos = new List<Mantenimiento>();
            var mantenimientosCliente = await _mantenimientoServicio.ObtenerMantenimientosPorClienteId(ClienteId);
            if (mantenimientosCliente.Count >= 1)
            {
                double totalRepuestos = 0;
                double totalServicios = 0;
                factura.Mantenimientos = mantenimientosCliente;
                foreach (var mantenimiento in factura.Mantenimientos)
                {
                    var repuestosPorMantenimientos = await _repuestosMantenimientosServicio.ObtenerRepuestosPorMantenimientoId(mantenimiento.Id);
                    if (repuestosPorMantenimientos.Count >= 1)
                    {
                        factura.Repuestos = repuestosPorMantenimientos;
                        foreach (var repuesto in repuestosPorMantenimientos)
                        {
                            totalRepuestos = totalRepuestos + repuesto.Repuesto.PrecioUnitario;
                        }
                    }
                    var serviciosPorMantenimientos = await _serviciosMantenimientosServicio.obtenerServiciosPorMantenimiento(mantenimiento.Id);
                    if (serviciosPorMantenimientos.Count >= 1)
                    {
                        factura.ServiciosMantenimientos = serviciosPorMantenimientos;
                        foreach (var servicio in serviciosPorMantenimientos)
                        {
                            totalServicios = totalServicios + servicio.Servicio.Precio;
                        }
                    }
                }
                factura.TotalRepuestos = totalRepuestos;
                factura.TotalServicios = totalServicios;
                //Descuento del 50% cuando el total de los repuestos sea mayor a 3.000.000
                if (factura.TotalRepuestos >= 3000000)
                {
                    factura.TotalServicios = ((factura.TotalServicios * 50) / 100);
                }
                factura.TotalSinIva = factura.TotalServicios + factura.TotalRepuestos;
                factura.TotalConIva = ((factura.TotalSinIva * 19) / 100) + factura.TotalSinIva;
                if (factura.TotalConIva >= cliente.PresupuestoMaximo)
                {
                    return null;
                }
                else
                {
                    return factura;
                }

            }
            else
            {
                return null;
            }

        }
    }
}
