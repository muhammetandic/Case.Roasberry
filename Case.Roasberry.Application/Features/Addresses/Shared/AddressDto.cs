using Case.Roasberry.Core.ValueObjects;

namespace Case.Roasberry.Application.Features.Addresses.Shared;
public class AddressDto
{
    public Guid Id { get; set; }
    public string? Country { get; set; }
    public string? City { get; set; }
    public string? District { get; set; }
    public string? AddressLine { get; set; }
    public string? PostalCode { get; set; }
    public InvoiceInfo? InvoiceInfo { get; set; }
    public Guid CustomerId { get; set; }
}
