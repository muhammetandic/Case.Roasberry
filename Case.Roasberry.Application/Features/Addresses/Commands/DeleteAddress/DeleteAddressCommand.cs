using MediatR;

namespace Case.Roasberry.Application.Features.Addresses.Commands.DeleteAddress;
public class DeleteAddressCommand : IRequest
{
    public Guid Id { get; set; }

    public DeleteAddressCommand(Guid id)
    {
        Id = id;
    }
}
