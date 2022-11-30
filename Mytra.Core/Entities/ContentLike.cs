namespace Mytra.Core
{
    public class ContentLike : Base<ContentLike>
    {
        public Guid? Content { get; set; }
        public Guid? User { get; set; }
        public virtual Content? ContentNavigation { get; set; }
        public virtual User? UserNavigation { get; set; }
    }
}