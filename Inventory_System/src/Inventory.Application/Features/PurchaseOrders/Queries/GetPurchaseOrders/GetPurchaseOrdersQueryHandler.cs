using Inventory.Application.Features.PurchaseOrders.DTOs;
using Inventory.Application.Features.SalesOrders.DTOs;
using Inventory.Application.Interfaces.Persistence;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Inventory.Application.Features.PurchaseOrders.Queries.GetPurchaseOrders
{
    public class GetPurchaseOrdersQueryHandler : IRequestHandler<GetPurchaseOrdersQuery, IEnumerable<PurchaseOrderDto>>
    {
        private readonly IApplicationDbContext _context;
        public GetPurchaseOrdersQueryHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<PurchaseOrderDto>> Handle(GetPurchaseOrdersQuery request, CancellationToken cancellationToken)
        {
            return await _context.PurchaseOrders.Include(x => x.Supplier)
                .Select( x => new PurchaseOrderDto
                {
                    Id = x.Id,
                    Supplier = x.Supplier.Name,
                    Total = x.Total,
                    Status = x.Status
                }).ToListAsync(cancellationToken);
        }
    }
}
