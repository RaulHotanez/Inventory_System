
namespace Inventory.Application.Features.Warehouses.DTOs
{
    internal class WarehouseDto
    {
        public Guid Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public string? Location { get; set; }
    }
}
