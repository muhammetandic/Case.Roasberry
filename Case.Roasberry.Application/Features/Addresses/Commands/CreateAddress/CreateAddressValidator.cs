using FluentValidation;

namespace Case.Roasberry.Application.Features.Addresses.Commands.CreateAddress;
public class CreateAddressValidator : AbstractValidator<CreateAddressCommand>
{
    public CreateAddressValidator()
    {
        RuleFor(p => p.City).NotEmpty().NotNull();
        RuleFor(p => p.District).NotEmpty().NotNull();
        RuleFor(p => p.AddressLine).NotNull().NotNull();
        RuleFor(p=>p.CustomerId).NotEmpty().NotNull();
    }
}
