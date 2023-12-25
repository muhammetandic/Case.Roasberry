using Case.Roasberry.Core.Common;
using Case.Roasberry.Core.ValueObjects;

namespace Case.Roasberry.Core.Entities;
public class Address : BaseEntity
{
    public string? Phone { get; set; }
    public string? Country { get; set; }
    public string? City { get; set; }
    public string? District { get; set; }
    public string? AddressLine { get; set; }
    public string? PostalCode { get; set; }
    public InvoiceInfo? InvoiceInfo { get; set; }

    public Guid CustomerId { get; set; }
    public Customer? Customer { get; set; }
}
