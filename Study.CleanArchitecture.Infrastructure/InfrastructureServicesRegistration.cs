using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Study.CleanArchitecture.Application.Contracts.Email;
using Study.CleanArchitecture.Application.Contracts.Logging;
using Study.CleanArchitecture.Application.Models.Email;
using Study.CleanArchitecture.Infrastructure.EmailService;
using Study.CleanArchitecture.Infrastructure.Logging;

namespace Study.CleanArchitecture.Infrastructure;

public static class InfrastructureServicesRegistration
{
    public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.Configure<EmailSettings>(c => configuration.GetSection("EmailSettings"));
        services.AddTransient<IEmailSender, EmailSender>();
        services.AddScoped(typeof(IAppLogger<>), typeof(LoggerAdapter<>));
        return services;
    }
}