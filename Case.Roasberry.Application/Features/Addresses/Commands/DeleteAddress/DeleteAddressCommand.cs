using MediatR;

namespace Case.Roasberry.Application.Features.Addresses.Commands.DeleteAddress;
public class DeleteAddressCommand : IRequest
{
    public required Guid Id { get; set; }
}
