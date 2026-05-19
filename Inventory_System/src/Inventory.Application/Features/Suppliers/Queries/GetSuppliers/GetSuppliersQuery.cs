using Inventory.Application.Features.Suppliers.DTOs;
using MediatR;

namespace Inventory.Application.Features.Suppliers.Queries.GetSuppliers
{
    public class GetSuppliersQuery : IRequest<IEnumerable<SupplierDto>>
    {
    }
}
