namespace Mytra.Core
{
    public class ContentDetailWebResponse : BaseWebResponse<ContentDetailWebResponse>
    {
        public ContentDetail ContentDetail { get; set; } = null!;
    }
}