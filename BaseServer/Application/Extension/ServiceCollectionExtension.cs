using System.Reflection;

namespace Application.Extension;

internal static class ServiceCollectionExtension
{
    internal static IServiceCollection AddApplicationMediator(this IServiceCollection services)
    {
        services.AddMediatR(Assembly.GetExecutingAssembly());

        return services;
    }
}
