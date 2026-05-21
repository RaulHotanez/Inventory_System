using FluentValidation;

namespace Inventory.Application.Features.SalesOrderItems.Commands.CreateSalesOrderItem
{
    public class CreateSalesOrderItemCommandValidator : AbstractValidator<CreateSalesOrderItemCommand>
    {
        public CreateSalesOrderItemCommandValidator()
        {
            RuleFor(x => x.Quantity)
               .GreaterThan(0);
        }
    }
}
