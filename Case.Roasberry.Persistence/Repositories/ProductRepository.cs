using Case.Roasberry.Application.Contracts.Persistence;
using Case.Roasberry.Core.Entities;

namespace Case.Roasberry.Persistence.Repositories;
public class ProductRepository : GenericRepository<Product>, IProductRepository
{
    public ProductRepository(ApplicationDbContext context) : base(context)
    {
    }
}
