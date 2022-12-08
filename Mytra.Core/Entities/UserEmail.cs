namespace Mytra.Core
{
    public class UserEmail : Base<UserEmail>, IEntity
    {
        public Guid? User { get; set; }
        public string? Email { get; set; }
        public virtual User? UserNavigation { get; set; }
    }
}