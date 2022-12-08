namespace Mytra.Core
{
    public class AnnounceDetailWebResponse : BaseWebResponse<AnnounceDetailWebResponse>
    {
        public AnnounceDetail AnnounceDetail { get; set; } = null!;
    }
}