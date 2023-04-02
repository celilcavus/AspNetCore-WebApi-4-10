using CelilCavus.WebApi.Context;
using CelilCavus.WebApi.Entites;
using CelilCavus.WebApi.Interface;
using CelilCavus.WebApi.Service;
using Microsoft.EntityFrameworkCore;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.

        builder.Services.AddControllers();

        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddScoped<DbContext, ETicaretContext>();
        builder.Services.AddScoped<IRepository<Category>, CategoryService>();
        builder.Services.AddScoped<IRepository<Orders>, OrdersService>();
        builder.Services.AddScoped<IRepository<User>, UserService>();
        builder.Services.AddScoped<IRepository<Product>, ProductService>();

        var app = builder.Build();



        app.UseHttpsRedirection();

        app.UseAuthorization();

        app.MapControllers();

        app.Run();
    }
}