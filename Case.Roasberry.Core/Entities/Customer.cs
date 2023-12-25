using Case.Roasberry.Core.Common;
using Case.Roasberry.Core.Enums;

namespace Case.Roasberry.Core.Entities;
public class Customer : BaseEntity
{
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    public required string Phone { get; set; }
    public required string Email { get; set; }
    public Gender? Gender { get; set; }
    public string? Nationality { get; set; }

    public ICollection<Order>? Orders { get; set; }
    public ICollection<Address>? Addresses { get; set; }
}
