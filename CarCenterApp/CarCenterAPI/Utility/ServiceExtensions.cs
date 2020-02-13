

using CarCenterCore.Repositorios;
using CarCenterCore.Servicios;
using CarCenterInfrastructure.Repositorios;
using CarCenterInfrastructure.Servicios;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarCenterApi.Utility
{
    public static class ServiceExtensions
    {
        public static IServiceCollection RegistroServiciosNegocio(this IServiceCollection services)
        {
            //Repositorios
            services.AddScoped<IClienteRepositorio, ClienteRepositorio>();
            services.AddScoped<IRepuestoRepositorio, RepuestoRepositorio>();
            services.AddScoped<IServicioRepositorio, ServicioRepositorio>();
            services.AddScoped<IVehiculoRepositorio, VehiculoRepositorio>();
            services.AddScoped<IMantenimientoRepositorio, MantenimientoRepositorio>();
            services.AddScoped<IMecanicoRepositorio, MecanicoRepositorio>();
            services.AddScoped<IRepuestoRepositorio, RepuestoRepositorio>();
            services.AddScoped<IFotoRepositorio, FotoRepositorio>();
            services.AddScoped<IMarcaRepositorio, MarcaRepositorio>();

            //Servicios
            services.AddScoped<IClienteServicio, ClienteServicio>();
            services.AddScoped<IRepuestoServicio, RepuestoServicio>();
            services.AddScoped<IServicioServicio, ServicioServicio>();
            services.AddScoped<IVehiculoServicio, VehiculoServicio>();

            services.AddScoped<IMantenimientoServicio, MantenimientoServicio>();
            services.AddScoped<IMecanicoServicio, MecanicoServicio>();
            services.AddScoped<IRepuestoServicio, RepuestoServicio>();
            services.AddScoped<IFotoServicio, FotoServicio>();
            services.AddScoped<IMarcaServicio, MarcaServicio>();

            return services;
        }

    }
}
