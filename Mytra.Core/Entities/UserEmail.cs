namespace Mytra.Core
{
    public class UserEmail : Base<UserEmail>
    {
        public Guid? User { get; set; }
        public virtual User? UserNavigation { get; set; }
    }
}