namespace Mytra.Core
{
    public class UserSettings : Base<UserSettings>, IEntity
    {
        public virtual User IdNavigation { get; set; } = null!;
    }
}