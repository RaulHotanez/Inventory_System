namespace Inventory.Application.Features.Products.DTOs;

public class ProductDto
{
    public Guid Id { get; set; }

    public string SKU { get; set; } = string.Empty;

    public string Name { get; set; } = string.Empty;

    public decimal Price { get; set; }

    public int Stock { get; set; }

    public string CategoryName { get; set; } = string.Empty;
}