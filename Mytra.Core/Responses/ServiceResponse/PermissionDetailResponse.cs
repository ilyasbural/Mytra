namespace Mytra.Core
{
    public class PermissionDetailResponse : BaseResponse<PermissionDetailResponse>
    {
        public PermissionDetail PermissionDetail { get; set; } = null!;
    }
}