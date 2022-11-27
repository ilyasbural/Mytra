namespace Mytra.Core
{
    public class Announce : Base<Announce>, IEntity
    {
        public string? Title { get; set; }
        public bool? IsActive { get; set; }
        public virtual ICollection<AnnounceDetail> AnnounceDetails { get; } = new List<AnnounceDetail>();
    }
}