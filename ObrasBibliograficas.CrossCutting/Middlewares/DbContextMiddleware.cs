using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ObrasBibliograficas.DataAcess;
using Microsoft.Extensions.Configuration;

namespace ObrasBibliograficas.CrossCutting.Middleware
{
    public static class DbContextMiddleware
    {

        public static void AddContext(this IServiceCollection services,IConfiguration configuration)
        {
            services.AddDbContext<Conexao>(option =>
            {
                option.UseSqlite(configuration.GetConnectionString("DefaultConnection"));
            });
        }

    }
}
