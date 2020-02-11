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
    public class FotoRepositorio : IFotoRepositorio
    {
        private readonly ApplicationDbContext _context;
        public FotoRepositorio(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Foto> ActualizarFoto(Foto modelo)
        {
            _context.Fotos.Update(modelo);
            await _context.SaveChangesAsync();
            return modelo;
        }

        public async Task<Foto> CrearFoto(Foto modelo)
        {
            modelo.Id = Guid.NewGuid();
            await _context.Fotos.AddAsync(modelo);
            await _context.SaveChangesAsync();
            return modelo;
        }

        public async Task<bool> EliminarFoto(Guid FotoId)
        {
            Foto Foto = await _context.Fotos.FirstOrDefaultAsync(c => c.Id == FotoId);
            _context.Fotos.Remove(Foto);
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<Foto> ObtenerFotoPorId(Guid FotoId)
        {
            return await _context.Fotos.FirstOrDefaultAsync(c => c.Id == FotoId);
        }

        public async Task<List<Foto>> ObtenerFotos()
        {
            return await _context.Fotos.ToListAsync();
        }
    }
}
