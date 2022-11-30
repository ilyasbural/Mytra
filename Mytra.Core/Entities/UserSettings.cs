namespace Mytra.Core
{
    public class UserSettings : Base<UserSettings>
    {
        public virtual User IdNavigation { get; set; } = null!;
    }
}