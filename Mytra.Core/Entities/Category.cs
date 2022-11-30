namespace Mytra.Core
{
    public class Category : Base<Category>, IEntity
    {
        public virtual ICollection<Content> Contents { get; } = new List<Content>();
    }
}