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
    public class ServiciosMantenimientosRepositorio : IServiciosMantenimientosRepositorio
    {
        private readonly ApplicationDbContext _context;
        public ServiciosMantenimientosRepositorio(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<ServiciosMantenimientos>> obtenerServiciosPorMantenimiento(Guid MantenimientoId)
        {
            return await _context.ServiciosMantenimientos
                .Include(c => c.Servicio)
                .Where(s => s.MantenimientoId == MantenimientoId).ToListAsync();
        }
    }
}
