using Inventory.Application.Features.Suppliers.DTOs;
using Inventory.Application.Interfaces.Persistence;
using MediatR;
using Microsoft.EntityFrameworkCore;


namespace Inventory.Application.Features.Suppliers.Queries.GetSuppliers
{
    public class GetSuppliersQueryHandler : IRequestHandler<GetSuppliersQuery, IEnumerable<SupplierDto>>
    {
        private readonly IApplicationDbContext _context;
        public GetSuppliersQueryHandler(IApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<SupplierDto>> Handle(GetSuppliersQuery request, CancellationToken cancellationToken)
        {
            return await _context.Suppliers.Select(x => new SupplierDto
            {
                Name = x.Name,
                Email = x.Email,
                Phone = x.Phone
            }).ToListAsync(cancellationToken);
        }
    }
}
