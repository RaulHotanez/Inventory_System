using Inventory.Application.Common.Models;
using MediatR;

namespace Inventory.Application.Features.Suppliers.Commands.CreateSupplier
{
    public class CreateSupplierCommand : IRequest<Result>
    {
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
    }
}
