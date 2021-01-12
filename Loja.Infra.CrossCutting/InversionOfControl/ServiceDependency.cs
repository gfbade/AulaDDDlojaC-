using Loja.Domain.Interfaces.Service;
using Loja.Service.Service;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Loja.Infra.CrossCutting.InversionOfControl
{
    public static class ServiceDependency
    {
        public static void AddServiceDependecy(this IServiceCollection services)
        {         
            services.AddScoped<ICategoriaService, CategoriaService>();
        }
    }
}
