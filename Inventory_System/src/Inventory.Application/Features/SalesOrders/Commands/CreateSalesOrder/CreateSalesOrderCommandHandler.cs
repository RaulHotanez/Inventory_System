using Inventory.Application.Common.Models;
using Inventory.Application.Interfaces.Persistence;
using Inventory.Domain.Entities;
using MediatR;

namespace Inventory.Application.Features.SalesOrders.Commands.CreateSalesOrder
{
    public class CreateSalesOrderCommandHandler : IRequestHandler<CreateSalesOrderCommand, Result>
    {
        private readonly IApplicationDbContext _context;
        public CreateSalesOrderCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<Result> Handle(CreateSalesOrderCommand request, CancellationToken cancellationToken)
        {
            var salesOrders = new SalesOrder
            {
                CustomerId = request.CustomerId,
                Total = request.Total,
                Status = request.Status
            };
            await _context.SalesOrders.AddAsync(salesOrders, cancellationToken);
            await _context.SaveChangesAsync(cancellationToken);
            return Result.Ok("SaleOrder created successfully");
        }
    }
}
