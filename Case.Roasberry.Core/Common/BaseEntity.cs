﻿
namespace Case.Roasberry.Core.Common;
public class BaseEntity : IEntity, IAuditable
{
    public Guid Id { get; set; }
    public DateTimeOffset? CreatedOn { get; set; }
    public Guid? CreatedBy { get; set; }
    public DateTimeOffset? ModifiedOn { get; set; }
    public Guid? ModifiedBy { get; set; }
}
