using FluentValidation;

namespace Case.Roasberry.Application.Features.Products.Commands.UpdateProduct;
public class UpdateProductValidator : AbstractValidator<UpdateProductCommand>
{
    public UpdateProductValidator()
    {
        RuleFor(p=>p.Name).NotEmpty().NotNull();
        RuleFor(p=>p.UnitPrice).GreaterThanOrEqualTo(0);
        RuleFor(p=>p.Discount).GreaterThanOrEqualTo(0);
    }
}
