using FluentValidation;

namespace Case.Roasberry.Application.Features.Products.Commands.CreateProduct;
public class CreateProductValidator : AbstractValidator<CreateProductCommand>
{
    public CreateProductValidator()
    {
        RuleFor(p=>p.Name).NotEmpty().NotNull();
        RuleFor(p=>p.UnitPrice).GreaterThanOrEqualTo(0);
        RuleFor(p=>p.Discount).GreaterThanOrEqualTo(0);
    }
}
