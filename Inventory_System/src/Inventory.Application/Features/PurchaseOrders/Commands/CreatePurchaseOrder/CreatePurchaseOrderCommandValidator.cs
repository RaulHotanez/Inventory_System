using FluentValidation;

namespace Inventory.Application.Features.PurchaseOrders.Commands.CreatePurchaseOrder
{
    public class CreatePurchaseOrderCommandValidator : AbstractValidator<CreatePurchaseOrderCommand>
    {
        public CreatePurchaseOrderCommandValidator()
        {
            RuleFor(x => x.Total)
                .GreaterThan(0);
        }
    }
}
