using Scalar.AspNetCore;
using Module3.Interfaces;
using Module3.Services;
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddOpenApi();

// =============== Add services to the container. ================
builder.Services.AddControllers();

// =========== Dependency Injection for UserService ===========
builder.Services.AddSingleton<IUserService, UserService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();

    // ============== Add Scalar API Reference (to test APIs, like Postman). ================
    app.MapScalarApiReference();
}

app.UseHttpsRedirection();

// ==================== Configure the HTTP request pipeline. ====================
app.MapControllers();

var summaries = new[]
{
    "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
};

app.MapGet("/weatherforecast", () =>
{
    var forecast =  Enumerable.Range(1, 5).Select(index =>
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

record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}
