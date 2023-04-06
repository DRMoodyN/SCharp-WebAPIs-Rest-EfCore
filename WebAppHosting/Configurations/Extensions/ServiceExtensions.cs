namespace WebAppHosting.Configurations.Extensions
{
    public static class ServiceExtensions
    {
        public static void ConfigureSql(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<WmsDbContext>(x =>
            {
                x.UseSqlServer(configuration.GetConnectionString("ConnectionSql"));
            });
        }

        public static void ConfigureRepository(this IServiceCollection services)
        {
            services.AddTransient<IUnitOfWord, UnitOfWord>();
        }

        public static void ConfigureService(this IServiceCollection services)
        {
            services.AddScoped<IServiceManager, ServiceManager>();
        }

        // Las aplicaciones ASP.NET Core están autohospedadas de forma predeterminada y, si 
        // queremos alojar nuestra aplicación en IIS, necesitamos configurar una integración 
        // de IIS que eventualmente nos ayudará con la implementación en IIS
        public static void ConfigureIISIntegration(this IServiceCollection services)
        {
            services.Configure<IISOptions>(iss =>
            {
                // Por ahorita esta bien con los valores predeterminados
            });
        }

        //CORS(Cross-Origin Resource Sharing)
        public static void ConfigureCors(this IServiceCollection services)
        {
            services.AddCors(cors =>
            {
                cors.AddPolicy("CorsPolicy", builder =>
                {
                    // Podemos usar WithOrigins("https://example.com") permite solo request de esa fuente
                    builder.AllowAnyOrigin() // Permite solicitudes de cualquier fuente
                    // Permite todos los metodos http
                    // WithMethods("POST", "GET") que solo permitirá métodos HTTP específicos.
                    .AllowAnyMethod()
                    // WithHeaders("accept", "contenttype") para permitir solo encabezados específicos.
                    .AllowAnyHeader();
                });
            });
        }
    }
}
