namespace Mytra.Core
{
    public class Permission : Base<Permission>
    {
        public virtual ICollection<PermissionDetail> PermissionDetails { get; } = new List<PermissionDetail>();
    }
}