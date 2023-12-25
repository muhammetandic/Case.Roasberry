namespace Case.Roasberry.Core.Common;
public interface IAuditable
{
    DateTimeOffset? CreatedOn { get; set; }
    Guid? CreatedBy { get; set; }
    DateTimeOffset? ModifiedOn { get; set; }
    Guid? ModifiedBy { get; set; }
}
