namespace Mytra.Core
{
    public class ContentType : Base<ContentType>
    {
        public virtual ICollection<Content> Contents { get; } = new List<Content>();
    }
}