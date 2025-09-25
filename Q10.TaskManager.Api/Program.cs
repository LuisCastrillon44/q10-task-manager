using Q10.TaskManager.Infrastructure.Interfaces;
using Q10.TaskManager.Infrastructure.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

builder.Services.AddSingleton<IConfig, SettingsRepository>();
builder.Services.AddSingleton<IConfig, EnvironmentRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

var MaxItemsPerPage = app.Configuration["MaxItemsPerPage:ApiKey"];

var env1 = app.Configuration["MaxItemsPerPage:ApiKey"];
var env2 = Environment.GetEnvironmentVariable("MaxItemsPerPage:ApiKey");

app.Run();

record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}
