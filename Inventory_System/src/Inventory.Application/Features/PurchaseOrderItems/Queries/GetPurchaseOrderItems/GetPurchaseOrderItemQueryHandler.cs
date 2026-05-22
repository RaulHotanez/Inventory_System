using Inventory.Application.Features.PurchaseOrderItems.DTOs;
using Inventory.Application.Interfaces.Persistence;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Inventory.Application.Features.PurchaseOrderItems.Queries.GetPurchaseOrderItems
{
    public class GetPurchaseOrderItemQueryHandler : IRequestHandler<GetPurchaseOrderItemQuery, IEnumerable<PurchaseOrderItemDto>>
    {
        private readonly IApplicationDbContext _context;
        public GetPurchaseOrderItemQueryHandler(IApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<PurchaseOrderItemDto>> Handle(GetPurchaseOrderItemQuery request, CancellationToken cancellationToken)
        {
            return await _context.PurchaseOrderItems
                .Include(x => x.PurchaseOrder)
                .Include(x => x.Product)
                .Select(x => new PurchaseOrderItemDto
                { 
                        Id = x.Id,
                        PurchaseOrderId = x.PurchaseOrder.Id,
                        ProductId = x.Product.Id,
                        Quantity = x.Quantity,
                        Price = x.Price
                 }).ToListAsync(cancellationToken);
        }
    }
}
