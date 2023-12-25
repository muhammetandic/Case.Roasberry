using Case.Roasberry.Application.Contracts.Persistence;
using MediatR;

namespace Case.Roasberry.Application.Features.Addresses.Commands.DeleteAddress;
public class DeleteAddressCommandHandler : IRequestHandler<DeleteAddressCommand>
{
    private readonly IAddressRepository _addressRepository;

    public DeleteAddressCommandHandler(IAddressRepository addressRepository)
    {
        _addressRepository = addressRepository;
    }

    public async Task Handle(DeleteAddressCommand request, CancellationToken cancellationToken)
    {
        await _addressRepository.DeleteAsync(request.Id);
    }
}
