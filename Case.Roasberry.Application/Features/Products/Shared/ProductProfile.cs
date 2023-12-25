using AutoMapper;
using Case.Roasberry.Application.Features.Products.Commands.CreateProduct;
using Case.Roasberry.Application.Features.Products.Commands.UpdateProduct;
using Case.Roasberry.Core.Entities;

namespace Case.Roasberry.Application.Features.Products.Shared;
public class ProductProfile : Profile
{
    protected ProductProfile()
    {
        CreateMap<Product, ProductDto>().ReverseMap();
        CreateMap<Product, CreateProductCommand>().ReverseMap();
        CreateMap<Product, UpdateProductCommand>().ReverseMap();
    }
}
