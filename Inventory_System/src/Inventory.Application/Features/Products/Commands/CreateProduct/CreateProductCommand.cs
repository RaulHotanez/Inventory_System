using Inventory.Application.Common.Models;
using MediatR;

namespace Inventory.Application.Features.Products.Commands.CreateProduct;

public class CreateProductCommand : IRequest<Result>
{
    public string SKU { get; set; } = string.Empty;

    public string Name { get; set; } = string.Empty;

    public string? Description { get; set; }

    public decimal Price { get; set; }

    public decimal Cost { get; set; }

    public int Stock { get; set; }

    public Guid CategoryId { get; set; }
}