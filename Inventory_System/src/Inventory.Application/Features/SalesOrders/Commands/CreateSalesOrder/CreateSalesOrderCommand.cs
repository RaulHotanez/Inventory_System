
using Inventory.Application.Common.Models;
using Inventory.Domain.Enums;
using MediatR;

namespace Inventory.Application.Features.SalesOrders.Commands.CreateSalesOrder
{
    public class CreateSalesOrderCommand : IRequest<Result>
    {
        public Guid CustomerId { get; set; }

        public decimal Total { get; set; }

        public OrderStatus Status { get; set; }
    }
}
