using CasgemMicroservice.Services.Order.Core.Application;
using CasgemMicroservice.Services.Order.Core.Application.Interfaces;
using CasgemMicroservice.Services.Order.Infrastructure.Persistance.Context;
using CasgemMicroservice.Services.Order.Infrastructure.Persistance.Repositories;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<OrderContext>();
builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));
builder.Services.AddApplicationServices(builder.Configuration);
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
