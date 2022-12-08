namespace Mytra.Core
{
    public class ContentCommentWebResponse : BaseWebResponse<ContentCommentWebResponse>
    {
        public ContentComment ContentComment { get; set; } = null!;
    }
}