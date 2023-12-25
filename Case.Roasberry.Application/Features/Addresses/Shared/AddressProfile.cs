using AutoMapper;
using Case.Roasberry.Application.Features.Addresses.Commands.CreateAddress;
using Case.Roasberry.Application.Features.Addresses.Commands.UpdateAddress;
using Case.Roasberry.Core.Entities;

namespace Case.Roasberry.Application.Features.Addresses.Shared;
public class AddressProfile : Profile
{
    public AddressProfile()
    {
        CreateMap<Address, AddressDto>().ReverseMap();
        CreateMap<Address, CreateAddressCommand>().ReverseMap();
        CreateMap<Address, UpdateAddressCommand>().ReverseMap();
    }
}
