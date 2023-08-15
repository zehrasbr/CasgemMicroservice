using Ocelot.DependencyInjection;
using Ocelot.Middleware;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddOcelot();
builder.Services.AddAuthentication().AddJwtBearer("GatewayAuthenticationScheme",
    option =>
    {
        option.Authority = builder.Configuration["IdentityServerUrl"];
        option.Audience = "resource_gateway";
        option.RequireHttpsMetadata = false;
    });

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

await app.UseOcelot();

app.Run();