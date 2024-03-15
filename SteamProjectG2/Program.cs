using Microsoft.AspNetCore.Cors.Infrastructure;
using business_logic;
using SteamProjectG2;
using data_access;
using Microsoft.Extensions.DependencyInjection;
using SteamProjectG2.Helpers;
using Microsoft.AspNetCore.Identity;
using data_access.data.Entities;
public class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        var connStr = builder.Configuration.GetConnectionString("LocalDb")!;

        // Add services to the container.

        builder.Services.AddControllers();
        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        builder.Services.AddDbContext(connStr);
        builder.Services.AddIdentity();
        builder.Services.AddRepositories(); 

        builder.Services.AutoMapper();
        builder.Services.AddFluentValidators();

        builder.Services.AddCustomServices();

        var app = builder.Build();

        using(var scope = app.Services.CreateScope())
        {
            scope.ServiceProvider.SeedRoles().Wait();
            scope.ServiceProvider.SeedAdmin().Wait();
        }

        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseHttpsRedirection();
        app.UseStaticFiles();

        app.UseMiddleware<MiddlewareErrorHandler>();

        app.UseAuthorization();

        app.MapControllers();

        app.Run();
    }
}