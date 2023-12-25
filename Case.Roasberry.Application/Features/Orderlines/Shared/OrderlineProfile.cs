using AutoMapper;
using Case.Roasberry.Application.Features.Orderlines.Commands.CreateOrderline;
using Case.Roasberry.Application.Features.Orderlines.Commands.UpdateOrderline;
using Case.Roasberry.Core.Entities;

namespace Case.Roasberry.Application.Features.Orderlines.Shared;
public class OrderlineProfile : Profile
{
    public OrderlineProfile()
    {
        CreateMap<Orderline, OrderlineDto>().ReverseMap();
        CreateMap<Orderline, CreateOrderlineCommand>().ReverseMap();
        CreateMap<Orderline, UpdateOrderlineCommand>().ReverseMap();
    }
}
