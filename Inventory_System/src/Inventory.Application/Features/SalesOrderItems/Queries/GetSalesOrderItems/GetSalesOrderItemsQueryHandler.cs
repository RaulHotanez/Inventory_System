using Inventory.Application.Features.SalesOrderItems.DTOs;
using Inventory.Application.Interfaces.Persistence;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Inventory.Application.Features.SalesOrderItems.Queries.GetSalesOrderItems
{
    public class GetSalesOrderItemsQueryHandler : IRequestHandler<GetSalesOrderItemsQuery, IEnumerable<SalesOrderItemDto>>
    {
        private readonly IApplicationDbContext _context;
        public GetSalesOrderItemsQueryHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<SalesOrderItemDto>> Handle(GetSalesOrderItemsQuery request, CancellationToken cancellationToken)
        {
            return await _context.SalesOrderItems
                .Include(x => x.SalesOrder)
                .Include(x => x.Product)
                .Select(x => new SalesOrderItemDto
                {
                    Id = x.Id,
                    SalesOrderId = x.SalesOrder.Id,
                    ProductId = x.Product.Id,
                    Quantity = x.Quantity,
                    Price = x.Price
                }).ToListAsync(cancellationToken);
        }
    }
}
