using Serilog;

namespace Inventory.Infrastructure.Logging;

public static class SerilogConfiguration
{
    public static void ConfigureLogger()
    {
        Log.Logger = new LoggerConfiguration()
            .WriteTo.Console()
            .WriteTo.File("logs/log-.txt",
                rollingInterval: RollingInterval.Day)
            .CreateLogger();
    }
}