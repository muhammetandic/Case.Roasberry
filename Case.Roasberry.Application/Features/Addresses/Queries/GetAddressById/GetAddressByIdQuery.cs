using Case.Roasberry.Application.Features.Addresses.Shared;
using MediatR;

namespace Case.Roasberry.Application.Features.Addresses.Queries.GetAddressById;
public class GetAddressByIdQuery : IRequest<AddressDto>
{
    public Guid Id { get; set; }

    public GetAddressByIdQuery(Guid id)
    {
        Id = id;
    }
}
