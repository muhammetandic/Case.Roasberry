using FluentValidation;

namespace Case.Roasberry.Application.Features.Orderlines.Commands.UpdateOrderline;
public class UpdateOrdelineValidator : AbstractValidator<UpdateOrderlineCommand>
{
    public UpdateOrdelineValidator()
    {
        RuleFor(p => p.Quantity).GreaterThanOrEqualTo(0);
        RuleFor(p=>p.UnitPrice).GreaterThanOrEqualTo(0);
        RuleFor(p=>p.Discount).GreaterThanOrEqualTo(0);
    }
}
