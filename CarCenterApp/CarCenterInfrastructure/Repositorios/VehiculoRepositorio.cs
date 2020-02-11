using CarCenterCore.Repositorios;
using CarCenterData.Context;
using CarCenterData.Entidades.Negocio;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CarCenterInfrastructure.Repositorios
{
    public class VehiculoRepositorio : IVehiculoRepositorio
    {
        private readonly ApplicationDbContext _context;
        public VehiculoRepositorio(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Vehiculo> ActualizarVehiculo(Vehiculo modelo)
        {
            _context.Vehiculos.Update(modelo);
            await _context.SaveChangesAsync();
            return modelo;
        }

        public async Task<Vehiculo> CrearVehiculo(Vehiculo modelo)
        {
            modelo.Id = Guid.NewGuid();
            await _context.Vehiculos.AddAsync(modelo);
            await _context.SaveChangesAsync();
            return modelo;
        }

        public async Task<bool> EliminarVehiculo(Guid VehiculoId)
        {
            Vehiculo Vehiculo = await _context.Vehiculos.FirstOrDefaultAsync(c => c.Id == VehiculoId);
            _context.Vehiculos.Remove(Vehiculo);
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<Vehiculo> ObtenerVehiculoPorId(Guid VehiculoId)
        {
            return await _context.Vehiculos.FirstOrDefaultAsync(c => c.Id == VehiculoId);
        }

        public async Task<List<Vehiculo>> ObtenerVehiculos()
        {
            return await _context.Vehiculos.ToListAsync();
        }
    }
}
