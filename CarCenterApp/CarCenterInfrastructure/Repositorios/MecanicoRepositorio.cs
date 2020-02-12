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
    public class MecanicoRepositorio : IMecanicoRepositorio
    {
        private readonly ApplicationDbContext _context;
        public MecanicoRepositorio(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Mecanico> ActualizarMecanico(Mecanico modelo)
        {
            _context.Mecanicos.Update(modelo);
            await _context.SaveChangesAsync();
            return modelo;
        }

        public async Task<Mecanico> CrearMecanico(Mecanico modelo)
        {
            modelo.Id = Guid.NewGuid();
            await _context.Mecanicos.AddAsync(modelo);
            await _context.SaveChangesAsync();
            return modelo;
        }

        public async Task<bool> EliminarMecanico(Guid MecanicoId)
        {
            Mecanico Mecanico = await _context.Mecanicos.FirstOrDefaultAsync(c => c.Id == MecanicoId);
            _context.Mecanicos.Remove(Mecanico);
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<Mecanico> ObtenerMecanicoPorId(Guid MecanicoId)
        {
            return await _context.Mecanicos.FirstOrDefaultAsync(c => c.Id == MecanicoId);
        }

        public async Task<List<Mecanico>> ObtenerMecanicos()
        {
            return await _context.Mecanicos.ToListAsync();
        }
    }
}
