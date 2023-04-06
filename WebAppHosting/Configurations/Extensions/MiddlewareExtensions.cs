using System;

namespace WebAppHosting.Configurations.Extensions
{
    public static class MiddlewareExtensions
    {
        public static void ConfigureExceptionHandler(this IApplicationBuilder app)
        {
            app.UseMiddleware<GlobalErrorHandler>();
        }
    }
}
