using Case.Roasberry.Application.Features.Products.Shared;
using MediatR;

namespace Case.Roasberry.Application.Features.Products.Queries.GetProductById;
public class GetProductByIdQuery : IRequest<ProductDto>
{
    public GetProductByIdQuery(Guid id)
    {
        Id = id;
    }
    public Guid Id { get; set; }
}
