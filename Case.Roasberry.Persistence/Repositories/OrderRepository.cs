using Case.Roasberry.Application.Contracts.Persistence;
using Case.Roasberry.Core.Entities;

namespace Case.Roasberry.Persistence.Repositories;
public class OrderRepository : GenericRepository<Order>, IOrderRepository
{
    public OrderRepository(ApplicationDbContext context) : base(context)
    {
    }
}
