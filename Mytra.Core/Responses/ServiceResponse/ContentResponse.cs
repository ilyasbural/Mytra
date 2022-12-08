namespace Mytra.Core
{
    public class ContentResponse : BaseResponse<ContentResponse>
    {
        public Content Content { get; set; } = null!;
    }
}