using Case.Roasberry.Application.Features.Statistics.Queries.BesSellerProducts;
using Case.Roasberry.Core.Entities;

namespace Case.Roasberry.Application.Contracts.Persistence;
public interface IProductRepository : IGenericRepository<Product>
{
    List<BestSellerProductDto> BestSellerProducts();
}
