using Inventory.Application.Features.Categories.DTOs;
using MediatR;

namespace Inventory.Application.Features.Categories.Queries.GetCategories;

public class GetCategoriesQuery: IRequest<IEnumerable<CategoryDto>>
{
}