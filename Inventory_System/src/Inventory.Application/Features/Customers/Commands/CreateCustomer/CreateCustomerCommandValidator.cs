using FluentValidation;
using Inventory.Application.Features.Suppliers.Commands.CreateSupplier;

namespace Inventory.Application.Features.Customers.Commands.CreateCustomer
{
    public class CreateCustomerCommandValidator : AbstractValidator<CreateSupplierCommand>
    {
        public CreateCustomerCommandValidator() 
        {
            RuleFor(x => x.Email)
            .NotEmpty()
            .MaximumLength(200);

            RuleFor(x => x.Phone)
                .NotEmpty();
        }
    }
}
