namespace Mytra.Core
{
    public class UserWebResponse : BaseWebResponse<UserWebResponse>
    {
        public User User { get; set; } = null!;
    }
}