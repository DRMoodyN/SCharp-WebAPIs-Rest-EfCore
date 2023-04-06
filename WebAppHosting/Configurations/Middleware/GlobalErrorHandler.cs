using System;
using System.Net;

namespace WebAppHosting.Configurations.Middleware
{
    public class GlobalErrorHandler
    {
        private readonly RequestDelegate _next;
        public GlobalErrorHandler(RequestDelegate _next)
        {
            this._next = _next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch
            {
                await HandleExceptionAsync(context);
            }
        }

        private Task HandleExceptionAsync(HttpContext context)
        {
            context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
            context.Response.ContentType = "application/json";
            return context.Response.WriteAsync(new ErrorHandlerModel
            {
                Status = context.Response.StatusCode,
                Message = "Internal Server Error"
            }.ToString());
        }
    }
}
