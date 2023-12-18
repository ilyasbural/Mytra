namespace Mytra.Core
{
    public class Content : Base<Content>, IEntity
    {
        public Guid? ContentType { get; set; }
        public Guid? Category { get; set; }
        public string? Name { get; set; }

        public virtual Category? CategoryNavigation { get; set; }
        public virtual ICollection<ContentComment> ContentComments { get; } = new List<ContentComment>();
        public virtual ICollection<ContentLike> ContentLikes { get; } = new List<ContentLike>();
        public virtual ICollection<ContentPicture> ContentPictures { get; } = new List<ContentPicture>();
        public virtual ContentType? ContentTypeNavigation { get; set; }
    }
}