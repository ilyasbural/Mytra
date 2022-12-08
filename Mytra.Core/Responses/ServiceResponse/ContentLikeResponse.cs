namespace Mytra.Core
{
    public class ContentLikeResponse : BaseResponse<ContentLikeResponse>
    {
        public ContentLike ContentLike { get; set; } = null!;
    }
}