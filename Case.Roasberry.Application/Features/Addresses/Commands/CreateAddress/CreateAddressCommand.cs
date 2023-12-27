using Case.Roasberry.Application.Features.Addresses.Shared;
using Case.Roasberry.Core.ValueObjects;
using MediatR;

namespace Case.Roasberry.Application.Features.Addresses.Commands.CreateAddress;
public record CreateAddressCommand : IRequest<AddressDto>
{
    public string? Country { get; set; }
    public required string City { get; set; }
    public required string District { get; set; }
    public required string AddressLine { get; set; }
    public string? PostalCode { get; set; }
    public InvoiceInfo? InvoiceInfo { get; set; }
    public Guid? CustomerId { get; set; }
}
