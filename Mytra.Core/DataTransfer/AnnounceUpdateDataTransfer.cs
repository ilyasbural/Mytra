namespace Mytra.Core
{
    public class AnnounceUpdateDataTransfer : DataTransferBase<AnnounceUpdateDataTransfer>
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
    }
}