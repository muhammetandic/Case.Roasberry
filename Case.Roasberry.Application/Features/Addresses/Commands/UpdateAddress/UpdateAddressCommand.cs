using Case.Roasberry.Core.ValueObjects;
using MediatR;

namespace Case.Roasberry.Application.Features.Addresses.Commands.UpdateAddress;
public class UpdateAddressCommand : IRequest
{
    public Guid Id { get; set; }
    public string? Country { get; set; }
    public required string City { get; set; }
    public required string District { get; set; }
    public required string AddressLine { get; set; }
    public string? PostalCode { get; set; }
    public InvoiceInfo? InvoiceInfo { get; set; }
}
