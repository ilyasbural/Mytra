namespace Mytra.Core
{
    public class ContentComment : Base<ContentComment>, IEntity
    {
        public Guid? Content { get; set; }
        public Guid? User { get; set; }
        public string? Text { get; set; }

        public virtual Content? ContentNavigation { get; set; }
        public virtual User? UserNavigation { get; set; }
    }
}