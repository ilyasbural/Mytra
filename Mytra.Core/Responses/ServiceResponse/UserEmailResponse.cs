namespace Mytra.Core
{
    public class UserEmailResponse : BaseResponse<UserEmailResponse>
    {
        public UserEmail UserEmail { get; set; } = null!;
    }
}