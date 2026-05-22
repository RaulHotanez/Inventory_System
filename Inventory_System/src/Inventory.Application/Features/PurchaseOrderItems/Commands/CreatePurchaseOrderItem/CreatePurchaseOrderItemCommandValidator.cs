using FluentValidation;

namespace Inventory.Application.Features.PurchaseOrderItems.Commands.CreatePurchaseOrderItem
{
    public class CreatePurchaseOrderItemCommandValidator : AbstractValidator<CreatePurchaseOrderItemCommand>
    {
        public CreatePurchaseOrderItemCommandValidator()
        {
            RuleFor(x => x.Quantity)
               .GreaterThan(0);
        }
    }
}
