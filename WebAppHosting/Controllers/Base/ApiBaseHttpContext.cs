using System;

namespace WebAppHosting.Controllers
{
    public static class ApiBaseHttpContext
    {
        public static string GetUserNameSeccion(this HttpContext context)
        {
            return context.User.Identity.Name;
        }
    }
}
