using FluentValidation;

namespace Case.Roasberry.Application.Features.Addresses.Commands.UpdateAddress;
public class UpdateAddressValidator : AbstractValidator<UpdateAddressCommand>
{
    public UpdateAddressValidator()
    {
        RuleFor(p=>p.City).NotNull().NotEmpty();
        RuleFor(p=>p.District).NotNull().NotEmpty();
        RuleFor(p=>p.AddressLine).NotNull().NotEmpty();
    }
}
