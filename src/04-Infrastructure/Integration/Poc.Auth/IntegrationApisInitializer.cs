using Microsoft.Extensions.DependencyInjection;
using Poc.Auth.SendGrid.Interfaces;
using Poc.Auth.SendGrid.Services;

namespace Poc.Auth;

public class IntegrationApisInitializer
{
    public static void Initialize(IServiceCollection services)
    {
        services.AddHttpClient();
        services.AddScoped<ISendGridService, SendGridService>();
    }
}

