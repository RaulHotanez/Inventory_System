using Inventory.Application.Interfaces.Services;

namespace Inventory.Infrastructure.Services;

public class DateTimeProvider : IDateTimeProvider
{
    public DateTime UtcNow => DateTime.UtcNow;
}