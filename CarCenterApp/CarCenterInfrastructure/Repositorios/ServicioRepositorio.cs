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
    public class ServicioRepositorio : IServicioRepositorio
    {
        private readonly ApplicationDbContext _context;
        public ServicioRepositorio(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Servicio> ActualizarServicio(Servicio modelo)
        {
            _context.Servicios.Update(modelo);
            await _context.SaveChangesAsync();
            return modelo;
        }

        public async Task<Servicio> CrearServicio(Servicio modelo)
        {
            modelo.Id = Guid.NewGuid();
            await _context.Servicios.AddAsync(modelo);
            await _context.SaveChangesAsync();
            return modelo;
        }

        public async Task<bool> EliminarServicio(Guid ServicioId)
        {
            Servicio Servicio = await _context.Servicios.FirstOrDefaultAsync(c => c.Id == ServicioId);
            _context.Servicios.Remove(Servicio);
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<Servicio> ObtenerServicioPorId(Guid ServicioId)
        {
            return await _context.Servicios.FirstOrDefaultAsync(c => c.Id == ServicioId);
        }

        public async Task<List<Servicio>> ObtenerServicios()
        {
            return await _context.Servicios.ToListAsync();
        }
    }
}
