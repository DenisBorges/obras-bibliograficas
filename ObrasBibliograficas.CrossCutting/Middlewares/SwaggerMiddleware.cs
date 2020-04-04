using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.PlatformAbstractions;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.Swagger;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ObrasBibliograficas.CrossCutting.Middleware
{
    public static class SwaggerMiddleware
    {

        public static void AddSwagger(this IServiceCollection services)
        {
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1",
                    new OpenApiInfo
                    {
                        Title = "ObrasBibliograficas",
                        Version = "v1",
                        Description = "Test project to register book authors",
                        Contact = new OpenApiContact
                        {
                            Name = "Denis de Almeida Borges",
                            Url = new Uri("https://github.com/")
                        }
                    });

                var caminhoAplicacao =
                    PlatformServices.Default.Application.ApplicationBasePath;
                var caminhoXmlDoc =
                    Path.Combine(caminhoAplicacao, $"ObrasBibliograficas.Application.xml");

                c.IncludeXmlComments(caminhoXmlDoc);
            });
        }


        public static void AddSwagger(this IApplicationBuilder app)
        {
            app.UseSwagger();

            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json",
                    "Api to Register bookAuthors");

                c.RoutePrefix = "swagger/v1";
            });
        }
    }
}
