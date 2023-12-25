using MediatR;

namespace Case.Roasberry.Application.Features.Orders.Commands.UpdateOrder;
public class UpdateOrderCommand : IRequest
{
    public Guid Id { get; set; }
    public DateTimeOffset OrderDate { get; set; }
    public required string OrderNumber { get; set; }
    public decimal TotalPrice { get; set; }
    public decimal TotalDiscount { get; set; }
    public decimal LastPrice { get; set; }

    public Guid InvoiceAddressId { get; set; }
    public Guid ShippingAddressId { get; set; }
}
