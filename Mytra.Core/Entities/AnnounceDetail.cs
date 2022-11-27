namespace Mytra.Core
{
    public class AnnounceDetail : Base<AnnounceDetail>, IEntity
    {
        public Guid? Announce { get; set; }
        public string? Detail { get; set; }
        public virtual Announce? AnnounceNavigation { get; set; }
    }
}