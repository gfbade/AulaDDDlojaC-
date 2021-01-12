using Loja.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;


namespace Loja.Infra.CrossCutting.InversionOfControl
{
    public static class LojaContextDependency
    {
        public static void AddLojaContextDependency(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<LojaContext>(options =>
            {
                var server = configuration["database:sqlserver:server"];            
                var database = configuration["database:sqlserver:database"];  

                options.UseSqlServer($"Server={server};Database={database};Trusted_Connection=True;", opt =>
                {
                    opt.CommandTimeout(180);
                    opt.EnableRetryOnFailure(5);
                    opt.MigrationsAssembly("Loja.Infra.Data");
                });
            });
        }

    }
}
