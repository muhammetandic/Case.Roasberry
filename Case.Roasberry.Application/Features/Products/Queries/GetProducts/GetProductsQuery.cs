using Case.Roasberry.Application.Features.Products.Shared;
using MediatR;

namespace Case.Roasberry.Application.Features.Products.Queries.GetProducts;
public class GetProductsQuery : IRequest<List<ProductDto>>
{
}
