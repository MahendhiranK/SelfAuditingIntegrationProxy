using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System.Text.Json;
using System.Text.Json.Nodes;

var builder = WebApplication.CreateBuilder(args);
builder.Logging.ClearProviders();
builder.Logging.AddConsole();

var app = builder.Build();

app.UseMiddleware<AuditMiddleware>();

app.MapPost("/proxy", async (HttpContext context) =>
{
    // Simulate forwarding logic
    await context.Response.WriteAsync("Request successfully passed through proxy.");
});

app.Run();
