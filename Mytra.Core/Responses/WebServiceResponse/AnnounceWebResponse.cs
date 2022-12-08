namespace Mytra.Core
{
    public class AnnounceWebResponse : BaseWebResponse<AnnounceWebResponse>
    {
        public Announce Announce { get; set; } = null!; 
    }
}