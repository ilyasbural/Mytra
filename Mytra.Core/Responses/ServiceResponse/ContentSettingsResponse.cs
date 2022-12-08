namespace Mytra.Core
{
    public class ContentSettingsResponse : BaseResponse<ContentSettingsResponse>
    {
        public ContentSettings ContentSettings { get; set; } = null!;
    }
}