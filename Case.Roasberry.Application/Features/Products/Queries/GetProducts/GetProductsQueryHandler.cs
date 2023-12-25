using AutoMapper;
using Case.Roasberry.Application.Contracts.Persistence;
using Case.Roasberry.Application.Features.Products.Shared;
using MediatR;

namespace Case.Roasberry.Application.Features.Products.Queries.GetProducts;
public class GetProductsQueryHandler : IRequestHandler<GetProductsQuery, List<ProductDto>>
{
    private readonly IMapper _mapper;
    private readonly IProductRepository _productRepository;

    public GetProductsQueryHandler(IMapper mapper, IProductRepository productRepository)
    {
        _mapper = mapper;
        _productRepository = productRepository;
    }

    public async Task<List<ProductDto>> Handle(GetProductsQuery request, CancellationToken cancellationToken)
    {
        var products = await _productRepository.GetAllAsync();
        var productsDto = _mapper.Map<List<ProductDto>>(products);
        return productsDto;
    }
}
