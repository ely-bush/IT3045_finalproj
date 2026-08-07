using IT3045_finalproj.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddOpenApiDocument(config =>
{
    config.Title = "IT3045 Final Project API";
    config.DocumentName = "IT3045_finalproj";
    config.Version = "v1";
});

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseOpenApi();
    app.UseSwaggerUi(config =>
    {
        config.DocumentTitle = "IT3045 Final Project API";
        config.Path = "/swagger";
        config.DocumentPath = "/swagger/IT3045_finalproj/swagger.json";
    });
}

app.MapControllers();
app.Run();