using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;

namespace LoggerScope;

public class LoggerMiddleware
{
    private readonly RequestDelegate _next;

    public LoggerMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    public async Task InvokeAsync(HttpContext context, ILogger<LoggerMiddleware> logger, ILoggerScopeService loggerScopeService)
    {
        using (logger.BeginScope(loggerScopeService.Properties))
        {
            await _next(context);
        }
    }
}
