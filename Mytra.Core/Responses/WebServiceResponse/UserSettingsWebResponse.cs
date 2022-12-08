namespace Mytra.Core
{
    public class UserSettingsWebResponse : BaseWebResponse<UserSettingsWebResponse>
    {
        public UserSettings UserSettings { get; set; } = null!;
    }
}