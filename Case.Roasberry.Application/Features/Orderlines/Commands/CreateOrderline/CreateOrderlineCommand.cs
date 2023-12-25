using Case.Roasberry.Application.Features.Orderlines.Shared;
using MediatR;

namespace Case.Roasberry.Application.Features.Orderlines.Commands.CreateOrderline;
public class CreateOrderlineCommand : IRequest<OrderlineDto>
{
    public Guid Id { get; set; }
    public int Quantity { get; set; }
    public decimal UnitPrice { get; set; }
    public decimal Discount { get; set; }

    public Guid? ProductId { get; set; }
    public Guid? OrderId { get; set; }
}
