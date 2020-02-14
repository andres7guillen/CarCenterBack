using CarCenterCore.Repositorios;
using CarCenterData.Context;
using CarCenterData.Entidades.Negocio;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarCenterInfrastructure.Repositorios
{
    public class MantenimientoRepositorio : IMantenimientoRepositorio
    {
        private readonly ApplicationDbContext _context;
        public MantenimientoRepositorio(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Mantenimiento> ActualizarMantenimiento(Mantenimiento modelo)
        {
            _context.Mantenimientos.Update(modelo);
            await _context.SaveChangesAsync();
            return modelo;
        }

        public async Task<Mantenimiento> CrearMantenimiento(Mantenimiento modelo)
        {
            modelo.Id = Guid.NewGuid();
            await _context.Mantenimientos.AddAsync(modelo);
            await _context.SaveChangesAsync();
            return modelo;
        }

        public async Task<bool> EliminarMantenimiento(Guid MantenimientoId)
        {
            Mantenimiento Mantenimiento = await _context.Mantenimientos.FirstOrDefaultAsync(c => c.Id == MantenimientoId);
            _context.Mantenimientos.Remove(Mantenimiento);
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<Mantenimiento> ObtenerMantenimientoPorId(Guid MantenimientoId)
        {
            return await _context.Mantenimientos.FirstOrDefaultAsync(c => c.Id == MantenimientoId);
        }

        public async Task<List<Mantenimiento>> ObtenerMantenimientos()
        {
            return await _context.Mantenimientos.ToListAsync();
        }

        public async Task<List<Mantenimiento>> ObtenerMantenimientosPorClienteId(Guid ClienteId)
        {
            return await _context.Mantenimientos
                .Include(c => c.Mecanico)
                .Where(m => m.Vehiculo.ClienteId == ClienteId).ToListAsync();
        }
    }
}
