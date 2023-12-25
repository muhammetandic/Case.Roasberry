using AutoMapper;
using Case.Roasberry.Application.Contracts.Persistence;
using Case.Roasberry.Application.Features.Addresses.Shared;
using MediatR;

namespace Case.Roasberry.Application.Features.Addresses.Queries.GetAddresses;
public class GetAddressesQueryHandler : IRequestHandler<GetAddressesQuery, List<AddressDto>>
{
    private readonly IMapper _mapper;
    private readonly IAddressRepository _addressRepository;

    public GetAddressesQueryHandler(IMapper mapper, IAddressRepository addressRepository)
    {
        _mapper = mapper;
        _addressRepository = addressRepository;
    }
    public async Task<List<AddressDto>> Handle(GetAddressesQuery request, CancellationToken cancellationToken)
    {
        var allAddresses = await _addressRepository.GetAllAsync();
        return _mapper.Map<List<AddressDto>>(allAddresses);
    }
}
