using Case.Roasberry.Core.Common;

namespace Case.Roasberry.Core.Entities;
public class Product : BaseEntity
{
    public required string Name { get; set; }
    public string? Category { get; set; }
    public decimal UnitPrice { get; set; }
    public decimal Discount { get; set; }
    public string? Properties { get; set; }

    public ICollection<Orderline>? Orderlines { get; set; }
}
