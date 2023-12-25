using FluentValidation;

namespace Case.Roasberry.Application.Features.Orderlines.Commands.CreateOrderline;
public class CreateOrderlineValidator : AbstractValidator<CreateOrderlineCommand>
{
    public CreateOrderlineValidator()
    {
        RuleFor(p=>p.OrderId).NotEmpty();
        RuleFor(p=>p.ProductId).NotEmpty();
        RuleFor(p=>p.Quantity).GreaterThanOrEqualTo(0);
        RuleFor(p=>p.UnitPrice).GreaterThanOrEqualTo(0);
        RuleFor(p=>p.Discount).GreaterThanOrEqualTo(0);
    }
}
