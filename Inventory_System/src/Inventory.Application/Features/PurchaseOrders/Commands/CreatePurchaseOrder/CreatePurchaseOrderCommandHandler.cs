using Inventory.Application.Common.Models;
using Inventory.Application.Interfaces.Persistence;
using Inventory.Domain.Entities;
using MediatR;

namespace Inventory.Application.Features.PurchaseOrders.Commands.CreatePurchaseOrder
{
    public class CreatePurchaseOrderCommandHandler : IRequestHandler<CreatePurchaseOrderCommand, Result>
    {
        private readonly IApplicationDbContext _context;
        public CreatePurchaseOrderCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Result> Handle(CreatePurchaseOrderCommand request, CancellationToken cancellationToken)
        {
            var purchaseOrder = new PurchaseOrder
            {
                SupplierId = request.SupplierId,
                Total = request.Total,
                Status = request.Status
            };
            await _context.PurchaseOrders.AddAsync(purchaseOrder, cancellationToken);
            await _context.SaveChangesAsync(cancellationToken);
            return Result.Ok("PurchaseOrder created successfully");
        }
    }
}
