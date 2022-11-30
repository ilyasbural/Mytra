namespace Mytra.Core
{
    public class Category : Base<Category>
    {
        public virtual ICollection<Content> Contents { get; } = new List<Content>();
    }
}