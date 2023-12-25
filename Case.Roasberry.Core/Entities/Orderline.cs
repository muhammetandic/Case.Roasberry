using Case.Roasberry.Core.Common;

namespace Case.Roasberry.Core.Entities;
public class Orderline : BaseEntity
{
    public uint Quantity { get; set; }
    public decimal UnitPrice { get; set; }
    public decimal Discount { get; set; }

    public Guid? ProductId { get; set; }
    public Guid? OrderId { get; set; }

    public Product? Product { get; set; }
    public Order? Order { get; set; }
}
