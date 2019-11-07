using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.PlatformAbstractions;
using Swashbuckle.AspNetCore.Swagger;
using System.IO;

namespace Guerra.Web.Extendions
{
    public static class SweggerExtendions
    {
        public static void SwaggerServices(this IServiceCollection services)
        {
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1",
                    new Info
                    {
                        Title = "Guerra.Projects",
                        Version = "v1",
                        Description = "Gestão de Empresa API Simulator",
                        Contact = new Contact
                        {
                            Name = "Only R - Only Research",
                            Url = "https://github.com/gustavoguerra/PaiGuerra"
                        }
                    });

                var caminhoAplicacao =
                    PlatformServices.Default.Application.ApplicationBasePath;
                var caminhoXmlDoc =
                    Path.Combine(caminhoAplicacao, $"Guerra.Web.xml");

                c.IncludeXmlComments(caminhoXmlDoc);
            });
        }

        public static void SwaggerApplication(this IApplicationBuilder app)
        {
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json",
                    "Gestão de Empresa");

                c.RoutePrefix = "api/docs";
            });
        }
    }
}
