var builder = WebApplication.CreateBuilder(args);

builder.Services.ConfigureSql(builder.Configuration);
builder.Services.ConfigureIISIntegration();
builder.Services.AddControllers();
builder.Services.ConfigureCors();
builder.Services.AddEndpointsApiExplorer();
builder.Services.ConfigureRepository();
builder.Services.ConfigureService();
builder.Services.ConfigureDTO();
builder.Services.AddAuthentication();
builder.Services.ConfigureIdentity();
builder.Services.ConfigureJwt(builder.Configuration);
builder.Services.AddSwaggerGen();

// Cambiar codigo de 400 a 422 con la validacion del ModelState
builder.Services.Configure<ApiBehaviorOptions>(opts =>
{
    opts.SuppressModelStateInvalidFilter = true;
});

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.ConfigureExceptionHandler();
app.UseHttpsRedirection();
app.UseCors("CorsPolicy");

// permite usar archivos estáticos para la solicitud. Si no establecemos una ruta 
// al directorio de archivos estáticos, utilizará un wwwroot
app.UseStaticFiles();

// Reenviará encabezados de proxy al solicitud actual
app.UseForwardedHeaders(new ForwardedHeadersOptions
{
    ForwardedHeaders = ForwardedHeaders.All
});

app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();
app.Run();
