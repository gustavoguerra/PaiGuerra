using Guerra.Business.Business;
using Guerra.Business.Interface;
using Guerra.Repository.Interfaces;
using Guerra.Repository.Repository;
using Guerra.Services.Interface;
using Guerra.Services.Service;
using Microsoft.Extensions.DependencyInjection;

namespace Guerra.Web.Extendions
{
    public static class DependencyInjection
    {
        public static void DependencyInsection(this IServiceCollection services)
        {
            DependencyInjectionServices(services);
            DependencyInjectionBusiness(services);
            DependencyInjectionRepository(services);
        }
        public static void DependencyInjectionServices(IServiceCollection services)
        {
            services.AddTransient<IMercadoriaService, MercadoriaService>();
        }
        public static void DependencyInjectionBusiness(IServiceCollection services)
        {
            services.AddTransient<IMercadoriaBusiness, MercadoriaBusiness>();
        }

        public static void DependencyInjectionRepository(IServiceCollection services)
        {
            services.AddSingleton<IMercadoriaRepository, MercadoriaRepository>();
        }

    }
}
