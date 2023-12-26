using Case.Roasberry.Application.Features.Addresses.Shared;
using Case.Roasberry.Application.Features.Customers.Shared;
using Case.Roasberry.Core.Enums;
using MediatR;

namespace Case.Roasberry.Application.Features.Customers.Commands.CreateCustomer;
public class CreateCustomerCommand : IRequest<CustomerDto>
{
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    public required string Phone { get; set; }
    public required string Email { get; set; }
    public Gender? Gender { get; set; }
    public string? Nationality { get; set; }

    public ICollection<AddressDto>? Addresses { get; set; }
}
