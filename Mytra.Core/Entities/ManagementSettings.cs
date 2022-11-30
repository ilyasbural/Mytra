namespace Mytra.Core
{
    public class ManagementSettings : Base<ManagementSettings>
    {
        public virtual Management IdNavigation { get; set; } = null!;
    }
}