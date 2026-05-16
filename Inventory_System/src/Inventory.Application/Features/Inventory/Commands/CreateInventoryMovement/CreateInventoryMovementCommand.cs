using Inventory.Application.Common.Models;
using Inventory.Domain.Enums;
using MediatR;

namespace Inventory.Application.Features.Inventory.Commands.CreateInventoryMovement;

public class CreateInventoryMovementCommand : IRequest<Result>
{
    public Guid ProductId { get; set; }

    public Guid WarehouseId { get; set; }

    public MovementType Type { get; set; }

    public int Quantity { get; set; }

    public string Reference { get; set; } = string.Empty;
}