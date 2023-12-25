using Case.Roasberry.Core.Entities;
using FluentValidation;

namespace Case.Roasberry.Application.Features.Customers.Commands.CreateCustomer;
public class CreateCustomerValidator : AbstractValidator<CreateCustomerCommand>
{
    public CreateCustomerValidator()
    {
        RuleFor(p=>p.FirstName).NotNull().NotEmpty();
        RuleFor(p=>p.LastName).NotNull().NotEmpty();
        RuleFor(p=>p.Phone).NotNull().NotEmpty();
        RuleFor(p=>p.Email).EmailAddress().NotNull().NotEmpty();
    }
}
