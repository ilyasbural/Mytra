namespace Mytra.Core
{
    public class AnnounceResponse : BaseResponse<AnnounceResponse>
    {
        public Announce Announce { get; set; } = null!; 
    }
}