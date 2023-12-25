using AutoMapper;
using Case.Roasberry.Application.Contracts.Persistence;
using Case.Roasberry.Application.Exceptions;
using Case.Roasberry.Application.Features.Addresses.Shared;
using Case.Roasberry.Core.Entities;
using MediatR;

namespace Case.Roasberry.Application.Features.Addresses.Commands.CreateAddress;
public class CreateAddressCommandHandler : IRequestHandler<CreateAddressCommand, AddressDto>
{
    private readonly IMapper _mapper;
    private readonly IAddressRepository _addressRepository;

    public CreateAddressCommandHandler(IMapper mapper, IAddressRepository addressRepository)
    {
        _mapper = mapper;
        _addressRepository = addressRepository;
    }

    public async Task<AddressDto> Handle(CreateAddressCommand request, CancellationToken cancellationToken)
    {
        var validator = new CreateAddressValidator();
        var validationResult = await validator.ValidateAsync(request, cancellationToken);
        if (validationResult.Errors.Count > 0)
        {
            throw new ValidationException(validationResult);
        }

        var address = _mapper.Map<Address>(request);
        address = await _addressRepository.InsertAsync(address);

        return _mapper.Map<AddressDto>(address);
    }
}
