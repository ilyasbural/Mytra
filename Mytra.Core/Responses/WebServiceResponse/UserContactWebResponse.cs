namespace Mytra.Core
{
    public class UserContactWebResponse : BaseWebResponse<UserContactWebResponse>
    {
        public UserContact UserContact { get; set; } = null!;
    }
}