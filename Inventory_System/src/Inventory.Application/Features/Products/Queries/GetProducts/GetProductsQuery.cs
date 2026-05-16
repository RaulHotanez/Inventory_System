using Inventory.Application.Features.Products.DTOs;
using MediatR;

namespace Inventory.Application.Features.Products.Queries.GetProducts;

public class GetProductsQuery : IRequest<IEnumerable<ProductDto>>
{
}