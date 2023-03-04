using CafeManager5000.DataAccess;
using CafeManager5000.DataAccess.Model;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddTransient(s => DaoFactory.Create<Product>());
builder.Services.AddTransient(s => DaoFactory.Create<Order>());

builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
