using Inventory.Application.Features.SalesOrders.DTOs;
using Inventory.Application.Interfaces.Persistence;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Inventory.Application.Features.SalesOrders.Queries.GetSalesOrders
{
    public class GetSalesOrdersQueryHandler : IRequestHandler<GetSalesOrdersQuery, IEnumerable<SalesOrderDto>>
    {
        private readonly IApplicationDbContext _context;
        public GetSalesOrdersQueryHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<SalesOrderDto>> Handle(GetSalesOrdersQuery request, CancellationToken cancellationToken)
        {
            return await _context.SalesOrders.Include(x => x.Customer)
                .Select(x => new SalesOrderDto
                {
                    Id = x.Id,
                    Customer = x.Customer.Name,
                    Total = x.Total,
                    Status = x.Status
                }).ToListAsync(cancellationToken);
        }
    }
}
