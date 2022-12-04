namespace Mytra.Core
{
    public class AnnounceUpdateDataTransfer : DataTransfer<AnnounceUpdateDataTransfer>
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
    }
}