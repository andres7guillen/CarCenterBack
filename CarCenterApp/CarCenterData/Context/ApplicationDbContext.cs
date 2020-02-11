using CarCenterCore.Entidades.Seguridad;
using CarCenterData.Entidades.Negocio;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarCenterData.Context
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser,UserRole,Guid>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Foto> Fotos { get; set; }
        public DbSet<Mantenimiento> Mantenimientos { get; set; }
        public DbSet<Marca> Marcas { get; set; }
        public DbSet<Mecanico> Mecanicos { get; set; }
        public DbSet<Repuesto> Repuestos { get; set; }
        public DbSet<RepuestosMantenimientos> RepuestosMantenimientos { get; set; }
        public DbSet<Servicio> Servicios { get; set; }
        public DbSet<ServiciosMantenimientos> ServiciosMantenimientos { get; set; }
        public DbSet<Vehiculo> Vehiculos { get; set; }




        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Cliente>()
                .HasMany(c => c.Vehiculos)
                .WithOne(v => v.Cliente);

            modelBuilder.Entity<Mantenimiento>()
                .HasMany(m => m.Fotos)
                .WithOne(f => f.Mantenimiento);





            modelBuilder.Entity<RepuestosMantenimientos>()
                .HasKey(m => new {
                    m.RepuestoId,
                    m.MantenimientoId
                });

            modelBuilder.Entity<ServiciosMantenimientos>()
                .HasKey(sm => new
                {
                    sm.ServicioId,
                    sm.MantenimientoId
                });

            modelBuilder.Entity<Marca>()
                .HasMany(m => m.Vehiculos)
                .WithOne(v => v.Marca);

            modelBuilder.Entity<Mecanico>()
                .HasMany(m => m.Mantenimientos)
                .WithOne(m => m.Mecanico);

            modelBuilder.Entity<Vehiculo>()
                .HasMany(v => v.Mantenimientos)
                .WithOne(m => m.Vehiculo);


            
        }
    }
}
