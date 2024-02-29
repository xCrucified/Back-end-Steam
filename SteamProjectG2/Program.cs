using Microsoft.AspNetCore.Cors.Infrastructure;
using business_logic;
using SteamProjectG2;

internal class Program
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

        builder.Services.AddAutoMapper();
        builder.Services.AddFluentValidators();

        builder.Services.AddCustomServices();

        var app = builder.Build();

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