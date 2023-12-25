using Case.Roasberry.Application.Features.Addresses.Shared;
using Case.Roasberry.Application.Features.Customers.Shared;
using Case.Roasberry.Application.Features.Orderlines.Shared;

namespace Case.Roasberry.Application.Features.Orders.Shared;
public class OrderDto
{
    public Guid Id { get; set; }
    public DateTimeOffset OrderDate { get; set; }
    public required string OrderNumber { get; set; }
    public decimal TotalPrice { get; set; }
    public decimal TotalDiscount { get; set; }
    public decimal LastPrice { get; set; }

    public CustomerDto? Customer { get; set; }
    public AddressDto? InvoiceAddress { get; set; }
    public AddressDto? ShippingAddress { get; set; }

    public ICollection<OrderlineDto>? Orderlines { get; set; }
}
