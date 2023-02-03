using Application.Common.Interface;
using Infrastructure.Service;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure.Extension;

internal static class ServiceCollectionExtension
{
    internal static IServiceCollection RegisterServiceImplementation(this IServiceCollection services)
    {
        services.AddScoped<ISuperHeroService, SuperHeroService>();

        return services;
    }
}
