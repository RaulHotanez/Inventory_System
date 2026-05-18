using Inventory.Application.Common.Exceptions;
using Inventory.Application.Common.Models;
using Inventory.Application.Interfaces.Persistence;
using Inventory.Application.Interfaces.Services;
using Inventory.Domain.Entities;
using Inventory.Domain.Enums;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Inventory.Application.Features.Inventory.Commands.CreateInventoryMovement;

public class CreateInventoryMovementCommandHandler : IRequestHandler<CreateInventoryMovementCommand, Result>
{
    private readonly IApplicationDbContext _context;
    private readonly ICurrentUserService _currentUserService;
    public CreateInventoryMovementCommandHandler(IApplicationDbContext context, ICurrentUserService currentUserService)
    {
        _context = context;
        _currentUserService = currentUserService;
    }

    public async Task<Result> Handle(CreateInventoryMovementCommand request, CancellationToken cancellationToken)
    {
        var product = await _context.Products
            .FirstOrDefaultAsync(
                x => x.Id == request.ProductId,
                cancellationToken);

        if (product is null)
        {
            throw new NotFoundException("Product not found");
        }

        var previousStock = product.Stock;

        switch (request.Type)
        {
            case MovementType.IN:

                product.Stock += request.Quantity;

                break;

            case MovementType.OUT:

                if (product.Stock < request.Quantity)
                {
                    throw new Exception("Insufficient stock");
                }

                product.Stock -= request.Quantity;

                break;

            case MovementType.ADJUSTMENT:

                product.Stock = request.Quantity;

                break;
        }

        var movement = new InventoryMovement
        {
            ProductId = request.ProductId,
            WarehouseId = request.WarehouseId,
            Type = request.Type,
            Quantity = request.Quantity,
            PreviousStock = previousStock,
            NewStock = product.Stock,
            Reference = request.Reference,
            UserId = _currentUserService.UserId
        };

        await _context.InventoryMovements.AddAsync(movement, cancellationToken);

        await _context.SaveChangesAsync(cancellationToken);

        return Result.Ok("Inventory updated successfully");
    }
}