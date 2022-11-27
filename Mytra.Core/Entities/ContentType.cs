namespace Mytra.Core
{
    public class ContentType : Base<ContentType>, IEntity
    {
        public virtual ICollection<Content> Contents { get; } = new List<Content>();
    }
}