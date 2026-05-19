using FluentValidation;

namespace Inventory.Application.Features.Suppliers.Commands.CreateSupplier
{
    public class CreateSupplierCommandValidator : AbstractValidator<CreateSupplierCommand>
    {
        public CreateSupplierCommandValidator() 
        {
            RuleFor(x => x.Email)
            .NotEmpty()
            .MaximumLength(200);

            RuleFor(x => x.Phone)
                .NotEmpty();

        }
    }
}
