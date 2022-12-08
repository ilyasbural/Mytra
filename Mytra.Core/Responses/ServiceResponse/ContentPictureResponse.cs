namespace Mytra.Core
{
    public class ContentPictureResponse : BaseResponse<ContentPictureResponse>
    {
        public ContentPicture ContentPicture { get; set; } = null!;
    }
}