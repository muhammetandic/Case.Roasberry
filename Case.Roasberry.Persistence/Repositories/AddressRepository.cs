using Case.Roasberry.Application.Contracts.Persistence;
using Case.Roasberry.Core.Entities;

namespace Case.Roasberry.Persistence.Repositories;
public class AddressRepository : GenericRepository<Address>, IAddressRepository
{
    public AddressRepository(ApplicationDbContext context) : base(context)
    {
    }
}
