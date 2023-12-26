using Case.Roasberry.Application.Features.Products.Shared;

namespace Case.Roasberry.Application.Features.Orderlines.Shared;
public class OrderlineDto
{
    public uint Quantity { get; set; }
    public decimal UnitPrice { get; set; }
    public decimal Discount { get; set; }

    public ProductDto? Product { get; set; }
}
