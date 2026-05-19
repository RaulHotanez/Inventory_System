using Inventory.Application.Common.Models;
using MediatR;

namespace Inventory.Application.Features.Categories.Commands.CreateCategory
{
    public class CreateCategoryCommand : IRequest<Result>
    {
        public string Name { get; set; } = string.Empty;

        public string? Description { get; set; }
    }
}
