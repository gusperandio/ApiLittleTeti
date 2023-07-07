using System.IO.Compression;
using System.Text;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.ResponseCompression;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

var builder = WebApplication.CreateBuilder(args);
ConfigureAuthentication(builder);
ConfigureMvc(builder);
ConfigureServices(builder);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();
LoadConfiguration(app);

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


if(app.Environment.IsProduction())
    Console.WriteLine("KurvyKat");

app.UseHttpsRedirection();
app.UseAuthentication();
app.UseAuthorization();
app.UseStaticFiles();
app.MapControllers();
app.MapControllers();

app.Run();

void LoadConfiguration(WebApplication appNoise)
{
    
}

void ConfigureAuthentication(WebApplicationBuilder building)
{

}
void ConfigureMvc(WebApplicationBuilder building)
{
    building.Services.AddMemoryCache();

    building.Services.AddResponseCompression(opt => { opt.Providers.Add<GzipCompressionProvider>(); });
    building.Services.Configure<GzipCompressionProviderOptions>(opt =>
    {
        opt.Level = CompressionLevel.Optimal;
    });

    building.Services.AddControllers()
        .ConfigureApiBehaviorOptions(opt => { opt.SuppressModelStateInvalidFilter = true; })
        .AddJsonOptions(x =>
        {
            x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles; //! Limitando nós
            x.JsonSerializerOptions.DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingDefault; //! Traz [] ao inves de null
        });
}
void ConfigureServices(WebApplicationBuilder modelBuild)
{
    var connectionString = modelBuild.Configuration.GetConnectionString("DefaultConnection");
}
