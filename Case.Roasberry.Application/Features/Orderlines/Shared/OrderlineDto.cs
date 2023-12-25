using Case.Roasberry.Core.Entities;

namespace Case.Roasberry.Application.Features.Orderlines.Shared;
public class OrderlineDto
{
    public uint Quantity { get; set; }
    public decimal UnitPrice { get; set; }
    public decimal Discount { get; set; }

    public Product? Product { get; set; }
    public Order? Order { get; set; }
}
