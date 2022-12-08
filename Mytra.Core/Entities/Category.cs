namespace Mytra.Core
{
    public class Category : Base<Category>, IEntity
    {
        public string? Name { get; set; }
        public virtual ICollection<Content> Contents { get; } = new List<Content>();
    }
}