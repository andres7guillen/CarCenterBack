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
    public class MarcaRepositorio : IMarcaRepositorio
    {
        private readonly ApplicationDbContext _context;
        public MarcaRepositorio(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Marca> ActualizarMarca(Marca modelo)
        {
            _context.Marcas.Update(modelo);
            await _context.SaveChangesAsync();
            return modelo;
        }

        public async Task<Marca> CrearMarca(Marca modelo)
        {
            modelo.Id = Guid.NewGuid();
            await _context.Marcas.AddAsync(modelo);
            await _context.SaveChangesAsync();
            return modelo;
        }

        public async Task<bool> EliminarMarca(Guid MarcaId)
        {
            Marca Marca = await _context.Marcas.FirstOrDefaultAsync(c => c.Id == MarcaId);
            _context.Marcas.Remove(Marca);
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<Marca> ObtenerMarcaPorId(Guid MarcaId)
        {
            return await _context.Marcas.FirstOrDefaultAsync(c => c.Id == MarcaId);
        }

        public async Task<List<Marca>> ObtenerMarcas()
        {
            return await _context.Marcas.ToListAsync();
        }
    }
}
