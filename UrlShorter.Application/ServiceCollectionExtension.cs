using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using MediatR;

namespace UrlShorter.Application
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddMediatR(Assembly.GetExecutingAssembly());

            return services;
        }
    }
}
