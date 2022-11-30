namespace Mytra.Core
{
    public class UserContact : Base<UserContact>, IEntity
    {
        public Guid? User { get; set; }
        public virtual User? UserNavigation { get; set; }
    }
}