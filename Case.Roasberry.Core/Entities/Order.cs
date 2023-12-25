using Case.Roasberry.Core.Common;

namespace Case.Roasberry.Core.Entities;
public class Order : BaseEntity
{
    public required DateTimeOffset OrderDate { get; set; }
    public required string OrderNumber { get; set; }
    public decimal TotalPrice { get; set; }
    public decimal TotalDiscount { get; set; }
    public decimal LastPrice { get; set; }

    public Guid CustomerId { get; set; }
    public Guid InvoiceAddressId { get; set; }
    public Guid ShippingAddressId { get; set; }

    public Customer? Customer { get; set; }
    public Address? InvoiceAddress { get; set; }
    public Address? ShippingAddress { get; set; }

    public ICollection<Orderline>? Orderlines { get; set; }
}
