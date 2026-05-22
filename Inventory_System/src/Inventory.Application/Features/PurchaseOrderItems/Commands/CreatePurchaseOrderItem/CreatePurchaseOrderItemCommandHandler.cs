using Inventory.Application.Common.Models;
using Inventory.Application.Interfaces.Persistence;
using Inventory.Domain.Entities;
using MediatR;

namespace Inventory.Application.Features.PurchaseOrderItems.Commands.CreatePurchaseOrderItem
{
    public class CreatePurchaseOrderItemCommandHandler : IRequestHandler<CreatePurchaseOrderItemCommand, Result>
    {
        private readonly IApplicationDbContext _context;
        public CreatePurchaseOrderItemCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<Result> Handle(CreatePurchaseOrderItemCommand request, CancellationToken cancellationToken)
        {
            var purchaseOrderItem = new PurchaseOrderItem
            {
                PurchaseOrderId = request.PurchaseOrderId,
                ProductId = request.ProductId,
                Quantity = request.Quantity,
                Price = request.Price
            };

            await _context.PurchaseOrderItems.AddAsync(purchaseOrderItem, cancellationToken);
            await _context.SaveChangesAsync(cancellationToken);
            return Result.Ok("PurchaseOrderItem created successfully");
        }
    }
}
