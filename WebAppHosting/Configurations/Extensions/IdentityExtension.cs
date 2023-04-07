namespace WebAppHosting.Configurations.Extensions
{
    public static class IdentityExtension
    {
        public static void ConfigureIdentity(this IServiceCollection service)
        {
            var builder = service.AddIdentity<User, IdentityRole>(user =>
            {
                user.Password.RequireDigit = true;
                user.Password.RequireLowercase = false;
                user.Password.RequireUppercase = false;
                user.Password.RequireNonAlphanumeric = false;
                user.Password.RequiredLength = 15;
                user.User.RequireUniqueEmail = true;
            })
            .AddEntityFrameworkStores<WmsDbContext>()
            .AddDefaultTokenProviders();
        }
    }
}
