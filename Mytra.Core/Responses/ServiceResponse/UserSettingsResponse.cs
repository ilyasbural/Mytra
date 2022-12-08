namespace Mytra.Core
{
    public class UserSettingsResponse : BaseResponse<UserSettingsResponse>
    {
        public UserSettings UserSettings { get; set; } = null!;
    }
}