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
    public class RepuestoRepositorio : IRepuestoRepositorio
    {
        private readonly ApplicationDbContext _context;
        public RepuestoRepositorio(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Repuesto> ActualizarRepuesto(Repuesto modelo)
        {
            _context.Repuestos.Update(modelo);
            await _context.SaveChangesAsync();
            return modelo;
        }

        public async Task<Repuesto> CrearRepuesto(Repuesto modelo)
        {
            modelo.Id = Guid.NewGuid();
            await _context.Repuestos.AddAsync(modelo);
            await _context.SaveChangesAsync();
            return modelo;
        }

        public async Task<bool> EliminarRepuesto(Guid RepuestoId)
        {
            Repuesto Repuesto = await _context.Repuestos.FirstOrDefaultAsync(c => c.Id == RepuestoId);
            _context.Repuestos.Remove(Repuesto);
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<Repuesto> ObtenerRepuestoPorId(Guid RepuestoId)
        {
            return await _context.Repuestos.FirstOrDefaultAsync(c => c.Id == RepuestoId);
        }

        public async Task<List<Repuesto>> ObtenerRepuestos()
        {
            return await _context.Repuestos.ToListAsync();
        }
    }
}
