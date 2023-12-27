using Case.Roasberry.Application.Contracts.Persistence;
using MediatR;

namespace Case.Roasberry.Application.Features.Statistics.Queries.BesSellerProducts;
public class BestSellerProductsQueryHandler : IRequestHandler<BestSellerProductsQuery, List<BestSellerProductDto>>
{
    private readonly IProductRepository _productRepository;

    public BestSellerProductsQueryHandler(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }

    public Task<List<BestSellerProductDto>> Handle(BestSellerProductsQuery request, CancellationToken cancellationToken)
    {
        var result = _productRepository.BestSellerProducts();
        return Task.FromResult(result);
    }
}
