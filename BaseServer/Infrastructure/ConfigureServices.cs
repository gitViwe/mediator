using Application;
using Infrastructure.Extension;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure;

public static class ConfigureServices
{
    public static IServiceCollection AddInfrastructureServices(this IServiceCollection services)
    {
        services.AddApplicationServices();
        services.RegisterServiceImplementation();

        return services;
    }
}