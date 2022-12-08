namespace Mytra.Core
{
    public class ManagementResponse : BaseResponse<ManagementResponse>
    {
        public Management Management { get; set; } = null!; 
    }
}