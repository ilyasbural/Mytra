namespace Mytra.Core
{
    public class PermissionDetail : Base<PermissionDetail>
    {
        public Guid? Permission { get; set; }
        public virtual Permission? PermissionNavigation { get; set; }
    }
}