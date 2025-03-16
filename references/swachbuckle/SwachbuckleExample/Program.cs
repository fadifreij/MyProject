using Scalar.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi

// By defalut the name of openapi is v1 and we can launch it by https://localhost:7104/openapi/v1.json
// We can change it by internal as below and we can launch it by https://localhost:7104/openapi/internal.json
builder.Services.AddOpenApi("internal");



//Limit OpenAPI document access to authorized users
//builder.Services.AddAuthentication().AddJwtBearer();
//builder.Services.AddAuthorization(o =>
//{
//    o.AddPolicy("ApiTesterPolicy", b => b.RequireRole("tester"));
//});

// Cache generated OpenAPI document
//builder.Services.AddOutputCache(options =>
//{
//    options.AddBasePolicy(policy => policy.Expire(TimeSpan.FromSeconds(10)));
//});

var app = builder.Build();
// Customize endpoint route
// we can call the open api by laucnh it by  https://localhost:7104/openapi/internal/openapi.json
//app.MapOpenApi("/openapi/{documentName}/openapi.json");

//Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    // https://localhost:7104/swagger/index.html
    //app.UseSwaggerUI(options =>
    //{
    //    options.SwaggerEndpoint("/openapi/internal.json", "v1");
    //});

    // https://localhost:7104/scalar/internal because the name of openapi is internal by default https://localhost:7104/scalar/v1
    app.MapScalarApiReference();

}
// Limit OpenAPI document access to authorized users
//app.MapOpenApi()
//    .RequireAuthorization("ApiTesterPolicy");

// Cache generated OpenAPI document
//app.UseOutputCache();

//app.MapOpenApi()
//    .CacheOutput();

// Generate OpenAPI documents at build-time
//Install-Package Microsoft.Extensions.ApiDescription.Server
// after build the solution you will find the file in obj/{ProjectName_OpenAPIname}.json


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

app.Run();

internal record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}
