using Case.Roasberry.Application.Features.Orders.Shared;
using MediatR;

namespace Case.Roasberry.Application.Features.Orders.Commands.CreateOrder;
public class CreateOrderCommand : IRequest<OrderDto>
{
    public required DateTimeOffset OrderDate { get; set; }
    public required string OrderNumber { get; set; }
    public decimal TotalPrice { get; set; }
    public decimal TotalDiscount { get; set; }
    public decimal LastPrice { get; set; }

    public Guid CustomerId { get; set; }
    public Guid InvoiceAddressId { get; set; }
    public Guid ShippingAddressId { get; set; }
}
