using Case.Roasberry.Application.Contracts.Persistence;
using Case.Roasberry.Application.Features.Statistics.Queries.BesSellerProducts;
using Case.Roasberry.Core.Entities;

namespace Case.Roasberry.Persistence.Repositories;
public class ProductRepository : GenericRepository<Product>, IProductRepository
{
    private readonly ApplicationDbContext _context;
    public ProductRepository(ApplicationDbContext context) : base(context)
    {
        _context = context;
    }

    public List<BestSellerProductDto> BestSellerProducts()
    {
        var result = (from orderline in _context.Orderlines
                     group orderline by orderline.Product.Name into g
                     orderby g.Sum(p=>p.Quantity) descending
                     select new BestSellerProductDto
                     {
                         ProductName = g.First().Product.Name,
                         Count = (uint)g.Sum(p => p.Quantity)
                     }).Take(5);
        return result.ToList();
    }
}
