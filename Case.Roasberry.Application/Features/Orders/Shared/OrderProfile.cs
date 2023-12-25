using AutoMapper;
using Case.Roasberry.Application.Features.Orders.Commands.CreateOrder;
using Case.Roasberry.Application.Features.Orders.Commands.UpdateOrder;
using Case.Roasberry.Core.Entities;

namespace Case.Roasberry.Application.Features.Orders.Shared;
public class OrderProfile : Profile
{
    public OrderProfile()
    {
        CreateMap<Order, OrderDto>().ReverseMap();
        CreateMap<Order, CreateOrderCommand>().ReverseMap();
        CreateMap<Order, UpdateOrderCommand>().ReverseMap();
    }
}
