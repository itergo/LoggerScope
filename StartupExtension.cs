using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace LoggerScope;

public static class StartupExtension
{
    public static void AddLoggerMiddleware(this IApplicationBuilder app)
    {
        app.UseMiddleware<LoggerMiddleware>();
    }
    public static void AddLoggerScopeService(this IServiceCollection services)
    {
        services.AddScoped<ILoggerScope, LoggerScope>();
    }
}
