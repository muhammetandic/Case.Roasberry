using MediatR;

namespace Case.Roasberry.Application.Features.Statistics.Queries.BesSellerProducts;
public class BestSellerProductsQuery : IRequest<List<BestSellerProductDto>>
{
    public DateTimeOffset StartDate { get; set; }
    public DateTimeOffset EndDate { get; set; }
}
