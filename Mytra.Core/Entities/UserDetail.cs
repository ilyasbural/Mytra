namespace Mytra.Core
{
    public class UserDetail : Base<UserDetail>
    {
        public virtual User IdNavigation { get; set; } = null!;
    }
}