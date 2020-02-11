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
    public class ClienteRepositorio : IClienteRepositorio
    {
        private readonly ApplicationDbContext _context;
        public ClienteRepositorio(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Cliente> ActualizarCliente(Cliente modelo)
        {
            _context.Clientes.Update(modelo);
            await _context.SaveChangesAsync();
            return modelo;
        }

        public async Task<Cliente> CrearCliente(Cliente modelo)
        {
            modelo.Id = Guid.NewGuid();
            await _context.Clientes.AddAsync(modelo);
            await _context.SaveChangesAsync();
            return modelo;
        }

        public async Task<bool> EliminarCliente(Guid ClienteId)
        {
            Cliente cliente = await _context.Clientes.FirstOrDefaultAsync(c => c.Id == ClienteId);
            _context.Clientes.Remove(cliente);
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<Cliente> ObtenerClientePorId(Guid ClienteId)
        {
            return await _context.Clientes.FirstOrDefaultAsync(c => c.Id == ClienteId);
        }

        public async Task<List<Cliente>> ObtenerClientes()
        {
            return await _context.Clientes.ToListAsync();
        }
    }
}
