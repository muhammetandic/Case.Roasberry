using Case.Roasberry.Core.Enums;
using MediatR;

namespace Case.Roasberry.Application.Features.Customers.Commands.UpdateCustomer;
public class UpdateCustomerCommand : IRequest
{
    public Guid Id { get; set; }
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    public required string Phone { get; set; }
    public required string Email { get; set; }
    public Gender? Gender { get; set; }
    public string? Nationality { get; set; }
}
