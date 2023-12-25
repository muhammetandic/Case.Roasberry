using Case.Roasberry.Application.Features.Addresses.Shared;
using MediatR;

namespace Case.Roasberry.Application.Features.Addresses.Queries.GetAddresses;
public class GetAddressesQuery : IRequest<List<AddressDto>>
{
}
