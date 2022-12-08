namespace Mytra.Core
{
    public class UserDetailWebResponse : BaseWebResponse<UserDetailWebResponse>
    {
        public UserDetail UserDetail { get; set; } = null!;
    }
}