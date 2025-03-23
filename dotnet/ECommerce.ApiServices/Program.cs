using E_Commerce.ApiServices.Providers;
using ECommerce.Persistence;
using ECommerce.ServiceAbstraction.Common;
using ECommerce.Services.Common;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata;



var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();


// Read the database provider from configuration
var databaseProvider = builder.Configuration["DatabaseProvider"]??"";




builder.AddDatabaseContext(databaseProvider);


builder.Services.AddServices();
builder.Services.AddControllers();
//builder.Services.AddControllers().
///               AddApplicationPart(typeof(AssemblyReference).Assembly);

builder.Services.AddControllers();



//var controllers = builder.Services.BuildServiceProvider().GetServices<ControllerBase>();
//Console.WriteLine($"Found {controllers.Count()} controllers.");

var app = builder.Build();

// Apply migrations and seed data
//using (var scope = app.Services.CreateScope())
//    {
//        var context = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
//        context.Database.EnsureCreated();
     
//        DbInitializer.Seed(context); // Run your custom seeding logic
//    }


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    // https://localhost:7049/swagger/index.html
    app.UseSwaggerUI(options =>
    {
        options.SwaggerEndpoint("/openapi/v1.json", "v1");
    });
}

app.UseHttpsRedirection();

var summaries = new[]
{
    "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
};

app.MapGet("/weatherforecast", () =>
{
    var forecast = Enumerable.Range(1, 5).Select(index =>
        new WeatherForecast
        (
            DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            Random.Shared.Next(-20, 55),
            summaries[Random.Shared.Next(summaries.Length)]
        ))
        .ToArray();
   

    return forecast;
})
.WithName("GetWeatherForecast");
app.MapControllers();
app.Run();

internal record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}
