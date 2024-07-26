var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var app = builder.Build();

// Configure the HTTP request pipeline.

var local1 = app.Configuration.GetSection("Nivel1").GetValue<string>("Nivel2a") ?? string.Empty;
var local2 = app.Configuration.GetSection("Nivel1").GetSection("Nivel2b").GetValue<string>("Nivel3") ?? string.Empty;

app.MapGet("/", () => Results.Json(new Dictionary<string, string> {
    { "local1", local1 },
     { "local2", local2 }
}));

app.Run();


