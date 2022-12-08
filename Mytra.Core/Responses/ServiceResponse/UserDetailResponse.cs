namespace Mytra.Core
{
    public class UserDetailResponse : BaseResponse<UserDetailResponse>
    {
        public UserDetail UserDetail { get; set; } = null!;
    }
}