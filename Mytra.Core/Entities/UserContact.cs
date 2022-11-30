namespace Mytra.Core
{
    public class UserContact : Base<UserContact>
    {
        public Guid? User { get; set; }
        public virtual User? UserNavigation { get; set; }
    }
}