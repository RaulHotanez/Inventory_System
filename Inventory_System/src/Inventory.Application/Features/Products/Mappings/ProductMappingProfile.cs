using AutoMapper;
using Inventory.Application.Features.Products.Commands.CreateProduct;
using Inventory.Application.Features.Products.Commands.UpdateProduct;
using Inventory.Application.Features.Products.DTOs;
using Inventory.Domain.Entities;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Inventory.Application.Features.Products.Mappings;

public class ProductMappingProfile : Profile
{
    public ProductMappingProfile()
    {
        CreateMap<Product, ProductDto>()
            .ForMember(dest => dest.CategoryName,
                opt => opt.MapFrom(src => src.Category.Name));

        CreateMap<CreateProductRequestDto, CreateProductCommand>();
        CreateMap<UpdateProductRequestDto, UpdateProductCommand>();
    }
}       