using Inventory.Application.Features.Customers.DTOs;
using MediatR;

namespace Inventory.Application.Features.Customers.Queries.GetCustomers
{
    public class GetCustomerQuery : IRequest<IEnumerable<CustomerDto>>
    {
    }
}
