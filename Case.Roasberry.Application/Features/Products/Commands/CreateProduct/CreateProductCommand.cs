using Case.Roasberry.Application.Features.Products.Shared;
using MediatR;

namespace Case.Roasberry.Application.Features.Products.Commands.CreateProduct;
public class CreateProductCommand : IRequest<ProductDto>
{
    public required string Name { get; set; }
    public string? Category { get; set; }
    public decimal UnitPrice { get; set; }
    public decimal Discount { get; set; }
    public string? Properties { get; set; }
}
