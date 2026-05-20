using Inventory.Application.Features.SalesOrders.DTOs;
using MediatR;

namespace Inventory.Application.Features.SalesOrders.Queries.GetSalesOrders
{
    public class GetSalesOrdersQuery : IRequest<IEnumerable<SalesOrderDto>>
    {
    }
}
