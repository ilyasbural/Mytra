namespace Mytra.Core
{
    public class ContentSettingsWebResponse : BaseWebResponse<ContentSettingsWebResponse>
    {
        public ContentSettings ContentSettings { get; set; } = null!;
    }
}