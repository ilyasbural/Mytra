namespace Mytra.Core
{
    public class ManagementContact : Base<ManagementContact>
    {
        public Guid? Management { get; set; }
        public virtual Management? ManagementNavigation { get; set; }
    }
}