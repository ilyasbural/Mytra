namespace Mytra.Core
{
    public class Permission : Base<Permission>, IEntity
    {
        public virtual ICollection<PermissionDetail> PermissionDetails { get; } = new List<PermissionDetail>();
    }
}