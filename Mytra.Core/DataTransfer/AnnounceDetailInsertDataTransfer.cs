namespace Mytra.Core
{
    public class AnnounceDetailInsertDataTransfer : DataTransferBase<AnnounceDetailInsertDataTransfer>
    {
        public Guid? Announce { get; set; }
        public string? Detail { get; set; }
    }
}