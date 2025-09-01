using myapp.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<DiceService>();
builder.Services.AddControllers();

var port = Environment.GetEnvironmentVariable("PORT") ?? "3000";
var url = $"http://0.0.0.0:{port}";
var target = Environment.GetEnvironmentVariable("TARGET") ?? "World";

var app = builder.Build();

builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(policy =>
    {
        policy.AllowAnyOrigin()
              .AllowAnyHeader()
              .AllowAnyMethod();
    });
});

app.UseCors();

app.MapControllers();

app.Run(url);