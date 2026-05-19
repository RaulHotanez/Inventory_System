using FluentValidation;

namespace Inventory.Application.Features.Warehouses.Commands.CreateWarehouse
{
    public class CreateWarehouseCommandValidator : AbstractValidator<CreateWarehouseCommand>
    {
        public CreateWarehouseCommandValidator() 
        {
            RuleFor(x => x.Name)
            .NotEmpty()
            .MaximumLength(100);
        }
    }
}
