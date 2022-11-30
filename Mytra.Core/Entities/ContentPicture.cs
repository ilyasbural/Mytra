namespace Mytra.Core
{
    public class ContentPicture : Base<ContentPicture>
    {
        public Guid? Content { get; set; }
        public virtual Content? ContentNavigation { get; set; }
    }
}