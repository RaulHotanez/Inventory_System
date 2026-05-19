using Inventory.Application.Common.Models;
using MediatR;

namespace Inventory.Application.Features.Warehouses.Commands.CreateWarehouse
{
    public class CreateWarehouseCommand : IRequest<Result>
    {
        public string Name { get; set; } = string.Empty;

        public string? Location { get; set; }
    }
}
