using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Facebook;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

// Add authentication services
builder.Services.AddAuthentication(options =>
{
    options.DefaultScheme = "Cookies";
    options.DefaultChallengeScheme = FacebookDefaults.AuthenticationScheme;
})
.AddCookie("Cookies")
.AddFacebook(facebookOptions =>
{
    //facebookOptions.AppId = "YOUR_FACEBOOK_APP_ID";
    //facebookOptions.AppSecret = "YOUR_FACEBOOK_APP_SECRET";
    facebookOptions.AppId = "827302512762265";
    facebookOptions.AppSecret = "c8222c8b9efd71ae8da2942110429cfe";
    facebookOptions.CallbackPath = "/signin-facebook"; // Must match the configured redirect URI in Facebook
});

builder.Services.AddAuthorization();



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}
// Enable authentication and authorization
app.UseAuthentication();
app.UseAuthorization();

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


// Login endpoint
app.MapGet("/login", async (HttpContext context) =>
{
    await context.ChallengeAsync(FacebookDefaults.AuthenticationScheme, new AuthenticationProperties
    {
        RedirectUri = "/private"
    });
});

// Private endpoint
app.MapGet("/private", (HttpContext context) =>
{
    return context.User.Identity?.IsAuthenticated ?? false
        ? Results.Ok($"Hello, {context.User.Identity.Name}")
        : Results.Unauthorized();
});

// Logout endpoint
app.MapGet("/logout", async (HttpContext context) =>
{
    await context.SignOutAsync("Cookies");
    return Results.Redirect("/");
});

app.Run();

internal record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}
