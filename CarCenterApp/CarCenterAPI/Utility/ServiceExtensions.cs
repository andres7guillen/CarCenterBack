

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
            
            services.AddScoped<IClienteRepositorio, ClienteRepositorio>();
            services.AddScoped<IClienteServicio, ClienteServicio>();

            services.AddScoped<IClienteServicio, ClienteServicio>();

            return services;
        }

    }
}
