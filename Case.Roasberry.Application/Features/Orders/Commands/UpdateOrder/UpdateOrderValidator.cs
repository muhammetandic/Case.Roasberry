using Case.Roasberry.Core.Entities;
using FluentValidation;

namespace Case.Roasberry.Application.Features.Orders.Commands.UpdateOrder;
public class UpdateOrderValidator : AbstractValidator<UpdateOrderCommand>
{
    public UpdateOrderValidator()
    {
        RuleFor(p => p.OrderNumber).NotNull().NotEmpty();
        RuleFor(p => p.OrderDate).NotNull().NotEmpty();
    }
}
