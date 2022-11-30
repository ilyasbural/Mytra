namespace Mytra.Core
{
    public class ManagementDetail : Base<ManagementDetail>, IEntity
    {
        public virtual Management IdNavigation { get; set; } = null!;
    }
}