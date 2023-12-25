using FluentValidation;

namespace Case.Roasberry.Application.Features.Orders.Commands.CreateOrder;
public class CreateOrderValidator : AbstractValidator<CreateOrderCommand>
{
    public CreateOrderValidator()
    {
        RuleFor(p=>p.OrderDate).NotNull().NotEmpty();
        RuleFor(p=>p.OrderNumber).NotNull().NotEmpty();
        RuleFor(p=>p.TotalPrice).GreaterThanOrEqualTo(0);
        RuleFor(p=>p.TotalDiscount).GreaterThanOrEqualTo(0);
        RuleFor(p=>p.LastPrice).GreaterThanOrEqualTo(0);
    }
}
