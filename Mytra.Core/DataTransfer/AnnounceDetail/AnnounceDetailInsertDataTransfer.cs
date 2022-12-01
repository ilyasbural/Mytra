namespace Mytra.Core
{
    public class AnnounceDetailInsertDataTransfer : DataTransfer<AnnounceDetailInsertDataTransfer>
    {
        public Guid? Announce { get; set; }
        public string? Detail { get; set; }
    }
}