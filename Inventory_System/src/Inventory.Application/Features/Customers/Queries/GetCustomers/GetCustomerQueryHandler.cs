using Inventory.Application.Features.Customers.DTOs;
using Inventory.Application.Interfaces.Persistence;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Inventory.Application.Features.Customers.Queries.GetCustomers
{
    public class GetCustomerQueryHandler : IRequestHandler<GetCustomerQuery, IEnumerable<CustomerDto>>
    {
        private readonly IApplicationDbContext _context;
        public GetCustomerQueryHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<CustomerDto>> Handle(GetCustomerQuery request, CancellationToken cancellationToken)
        {
            return await _context.Customers.Select(x => new CustomerDto 
            {
                Id = x.Id,
                Name = x.Name,
                Email = x.Email,
                Phone = x.Phone
            }).ToListAsync(cancellationToken);
        }
    }
}
