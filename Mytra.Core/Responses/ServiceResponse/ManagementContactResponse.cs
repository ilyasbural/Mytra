namespace Mytra.Core
{
    public class ManagementContactResponse : BaseResponse<ManagementContactResponse>
    {
        public ManagementContact ManagementContact { get; set; } = null!;
    }
}