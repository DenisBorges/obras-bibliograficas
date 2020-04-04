using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using ObrasBibliograficas.AppService;
using ObrasBibliograficas.AppService.Interface;
using ObrasBibliograficas.DataAcess;
using ObrasBibliograficas.DataAcess.Repository;
using ObrasBibliograficas.Domain.Interface;
using AutoMapper;
using ObrasBibliograficas.AppService.AutoMapper;
using Microsoft.Extensions.Logging;

namespace ObrasBibliograficas.CrossCutting
{
    public static class NativeInjectorBootStrapper
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            //ASPNET
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddSingleton<ILoggerFactory,LoggerFactory>();


            //AUTOMAPPER
            services.AddSingleton(AutoMapperConfiguration.RegisterMappings().CreateMapper());

            //DATAACESS
            services.AddScoped<Conexao>();

            //REPOSITORIES E APPSERVICES
            services.AddScoped<IAutorRepository, AutorRepository>();
            services.AddScoped<IAutorAppService, AutorAppService>();
        }


    }
}
