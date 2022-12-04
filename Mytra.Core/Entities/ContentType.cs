namespace Mytra.Core
{
    public class ContentType : Base<ContentType>, IEntity
    {
        public string? Name { get; set; }

        public virtual ICollection<Content> Contents { get; } = new List<Content>();
    }
}