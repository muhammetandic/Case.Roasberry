using Case.Roasberry.Core.Entities;
using FluentValidation;

namespace Case.Roasberry.Application.Features.Customers.Commands.UpdateCustomer;
public class UpdateCustomerValidator : AbstractValidator<UpdateCustomerCommand>
{
    public UpdateCustomerValidator()
    {
        RuleFor(p=>p.FirstName).NotNull().NotEmpty();
        RuleFor(p=> p.LastName).NotNull().NotEmpty();
        RuleFor(p=>p.Phone).NotNull().NotEmpty();
        RuleFor(p=>p.Email).EmailAddress().NotNull().NotEmpty();
    }
}
