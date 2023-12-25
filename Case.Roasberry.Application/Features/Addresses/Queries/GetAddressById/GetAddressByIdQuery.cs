using Case.Roasberry.Application.Features.Addresses.Shared;
using MediatR;

namespace Case.Roasberry.Application.Features.Addresses.Queries.GetAddressById;
public class GetAddressByIdQuery : IRequest<AddressDto>
{
    public required Guid Id { get; set; }
}
