using Inventory.Application.Common.Models;
using MediatR;

namespace Inventory.Application.Features.SalesOrderItems.Commands.CreateSalesOrderItem
{
    public class CreateSalesOrderItemCommand : IRequest<Result>
    {

        public Guid SalesOrderId { get; set; }

        public Guid ProductId { get; set; }

        public int Quantity { get; set; }

        public decimal Price { get; set; }
    }
}
