using Inventory.API.Extensions;
using Inventory.API.Middlewares;
using Inventory.Application;
using Inventory.Infrastructure;
using Inventory.Infrastructure.Logging;
using Serilog;

namespace Inventory.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // SERILOG
            SerilogConfiguration.ConfigureLogger();

            builder.Host.UseSerilog();

            // SERVICES
            builder.Services.AddControllers();

            builder.Services.AddEndpointsApiExplorer();

            builder.Services.AddSwaggerDocumentation();

            builder.Services.AddApplication();

            builder.Services.AddInfrastructure(builder.Configuration);

            builder.Services.AddAuthorization();

            // BUILD
            var app = builder.Build();

            // MIDDLEWARES
            app.UseMiddleware<ExceptionHandlingMiddleware>();

            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();

                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthentication();

            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}