namespace Mytra.Core
{
    public class ContentLikeWebResponse : BaseWebResponse<ContentLikeWebResponse>
    {
        public ContentLike ContentLike { get; set; } = null!;
    }
}