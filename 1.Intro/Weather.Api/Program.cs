using Weather.Api;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/weatherforecast", (ILogger<Program> logger) =>
{
    return Enumerable.Range(1, 5)
        .Select(index => new WeatherForecast(
                DateTime.Now.AddDays(index),
                Random.Shared.Next(-20, 55),
                WeatherData.Summaries[Random.Shared.Next(WeatherData.Summaries.Length)]))
        .ToArray();
});

app.Run();