using MediatR;

namespace Case.Roasberry.Application.Features.Orderlines.Commands.UpdateOrderline;
public class UpdateOrderlineCommand : IRequest
{
    public Guid Id { get; set; }
    public int Quantity { get; set; }
    public decimal UnitPrice { get; set; }
    public decimal Discount { get; set; }
}
