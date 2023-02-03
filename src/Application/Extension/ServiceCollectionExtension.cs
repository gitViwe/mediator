using Application.Common.Behaviour;
using FluentValidation;
using MediatR.Pipeline;
using System.Reflection;

namespace Application.Extension;

internal static class ServiceCollectionExtension
{
    internal static IServiceCollection AddApplicationMediator(this IServiceCollection services)
    {
        services.AddMediatR(Assembly.GetExecutingAssembly());
        services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
        services.AddTransient(typeof(IRequestPreProcessor<>), typeof(PreProcessBehaviour<>));
        services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationBehaviour<,>));

        return services;
    }
}
