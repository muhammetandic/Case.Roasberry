using AutoMapper;
using Case.Roasberry.Application.Contracts.Persistence;
using Case.Roasberry.Application.Exceptions;
using Case.Roasberry.Core.Entities;
using MediatR;

namespace Case.Roasberry.Application.Features.Addresses.Commands.UpdateAddress;
public class UpdateAddressCommandHandler : IRequestHandler<UpdateAddressCommand>
{
    private readonly IMapper _mapper;
    private readonly IAddressRepository _addressRepository;
    public UpdateAddressCommandHandler(IMapper mapper, IAddressRepository addressRepository)
    {
        _mapper = mapper;
        _addressRepository = addressRepository;
    }

    public async Task Handle(UpdateAddressCommand request, CancellationToken cancellationToken)
    {
        var addressToUpdate = await _addressRepository.GetByIdAsync(request.Id);
        if (addressToUpdate == null)
        {
            throw new NotFoundException(nameof(Address), request.Id);
        }
        var validator = new UpdateAddressValidator();
        var validationResult = await validator.ValidateAsync(request, cancellationToken);
        if (validationResult.Errors.Count > 0)
        {
            throw new ValidationException(validationResult);
        }

        await _addressRepository.UpdateAsync(addressToUpdate);
    }
}
