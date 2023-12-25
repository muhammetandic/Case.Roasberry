using MediatR;

namespace Case.Roasberry.Application.Features.Products.Commands.UpdateProduct;
public class UpdateProductCommand : IRequest
{
    public Guid Id { get; set; }
    public required string Name { get; set; }
    public string? Category { get; set; }
    public decimal UnitPrice { get; set; }
    public decimal Discount { get; set; }
    public string? Properties { get; set; }
}
