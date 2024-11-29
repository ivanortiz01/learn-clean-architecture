using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Study.CleanArchitecture.Application;

public static class ApplicationServiceRegistration
{
    public static IServiceCollection AddApplicationServices(
        this IServiceCollection services
    )
    {
        services.AddAutoMapper(Assembly.GetExecutingAssembly());

        services.AddMediatR(Assembly.GetExecutingAssembly());
        //cfg => cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly())

        return services;
    }
}
