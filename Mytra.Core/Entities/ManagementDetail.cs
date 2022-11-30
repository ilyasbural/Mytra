namespace Mytra.Core
{
    public class ManagementDetail : Base<ManagementDetail>
    {
        public virtual Management IdNavigation { get; set; } = null!;
    }
}