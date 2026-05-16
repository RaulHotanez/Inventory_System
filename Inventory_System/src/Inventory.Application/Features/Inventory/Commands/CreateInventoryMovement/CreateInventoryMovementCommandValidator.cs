using FluentValidation;

namespace Inventory.Application.Features.Inventory.Commands.CreateInventoryMovement;

public class CreateInventoryMovementCommandValidator : AbstractValidator<CreateInventoryMovementCommand>
{
    public CreateInventoryMovementCommandValidator()
    {
        RuleFor(x => x.ProductId)
            .NotEmpty();

        RuleFor(x => x.Quantity)
            .GreaterThan(0);

        RuleFor(x => x.Reference)
            .NotEmpty();
    }
}