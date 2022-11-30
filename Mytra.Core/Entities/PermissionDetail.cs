namespace Mytra.Core
{
    public class PermissionDetail : Base<PermissionDetail>, IEntity
    {
        public Guid? Permission { get; set; }
        public virtual Permission? PermissionNavigation { get; set; }
    }
}