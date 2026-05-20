using FluentValidation;
using Inventory.Application.Features.Products.Commands.CreateProduct;

namespace Inventory.Application.Features.SalesOrders.Commands.CreateSalesOrder
{
    public class CreateSalesOrderCommandValidator : AbstractValidator<CreateSalesOrderCommand>
    {
       public CreateSalesOrderCommandValidator() 
       {
            RuleFor(x => x.Total)
                .GreaterThan(0);
        }
    }
}
