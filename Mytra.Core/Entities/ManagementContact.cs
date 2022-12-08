namespace Mytra.Core
{
    public class ManagementContact : Base<ManagementContact>, IEntity
    {
        public Guid? Management { get; set; }
        public string? Phone { get; set; }
        public virtual Management? ManagementNavigation { get; set; }
    }
}