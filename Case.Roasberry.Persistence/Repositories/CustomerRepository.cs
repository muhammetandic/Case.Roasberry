using Case.Roasberry.Application.Contracts.Persistence;
using Case.Roasberry.Core.Entities;

namespace Case.Roasberry.Persistence.Repositories;
public class CustomerRepository : GenericRepository<Customer>, ICustomerRepository
{
    public CustomerRepository(ApplicationDbContext context) : base(context)
    {
    }
}
