namespace Mytra.Core
{
    public class ManagementSettings : Base<ManagementSettings>, IEntity
    {
        public virtual Management IdNavigation { get; set; } = null!;
    }
}