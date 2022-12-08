namespace Mytra.Core
{
    public class UserResponse : BaseResponse<UserResponse>
    {
        public User User { get; set; } = null!;
    }
}