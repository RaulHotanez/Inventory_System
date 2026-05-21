using Inventory.Application.Common.Models;
using Inventory.Application.Interfaces.Persistence;
using Inventory.Domain.Entities;
using MediatR;

namespace Inventory.Application.Features.SalesOrderItems.Commands.CreateSalesOrderItem
{
    public class CreateSalesOrderItemCommandHandler : IRequestHandler<CreateSalesOrderItemCommand, Result>
    {
        private readonly IApplicationDbContext _context;
        public CreateSalesOrderItemCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Result> Handle(CreateSalesOrderItemCommand request, CancellationToken cancellationToken)
        {
            var salesOrderItem = new SalesOrderItem
            {
                SalesOrderId = request.SalesOrderId,
                ProductId = request.ProductId,
                Quantity = request.Quantity,
                Price = request.Price
            };

            await _context.SalesOrderItems.AddAsync(salesOrderItem, cancellationToken);
            await _context.SaveChangesAsync(cancellationToken);
            return Result.Ok("SalesOrderItem created successfully");
        }
    }
}
