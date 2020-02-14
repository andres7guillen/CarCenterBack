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
    public class RepuestosMantenimientosRepositorio : IRepuestosMantenimientosRepositorio
    {
        private readonly ApplicationDbContext _context;
        public RepuestosMantenimientosRepositorio(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<List<RepuestosMantenimientos>> ObtenerRepuestosPorMantenimientoId(Guid MantenimientoId)
        {
            return await _context.RepuestosMantenimientos
                .Include(c => c.Repuesto)
                .Where(r => r.MantenimientoId == MantenimientoId).ToListAsync();
        }
    }
}
