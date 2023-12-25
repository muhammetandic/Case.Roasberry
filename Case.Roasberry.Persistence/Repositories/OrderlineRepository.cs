using Case.Roasberry.Application.Contracts.Persistence;
using Case.Roasberry.Core.Entities;

namespace Case.Roasberry.Persistence.Repositories;
public class OrderlineRepository : GenericRepository<Orderline>, IOrderlineRepository
{
    public OrderlineRepository(ApplicationDbContext context) : base(context)
    {
    }
}
