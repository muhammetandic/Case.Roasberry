using AutoMapper;
using Case.Roasberry.Application.Features.Customers.Commands.CreateCustomer;
using Case.Roasberry.Application.Features.Customers.Commands.UpdateCustomer;
using Case.Roasberry.Core.Entities;

namespace Case.Roasberry.Application.Features.Customers.Shared;
public class CustomerProfile : Profile
{
    public CustomerProfile()
    {
        CreateMap<Customer, CustomerDto>().ReverseMap();
        CreateMap<Customer, CreateCustomerCommand>().ReverseMap();
        CreateMap<Customer, UpdateCustomerCommand>().ReverseMap();
    }
}
