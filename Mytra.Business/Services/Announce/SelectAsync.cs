namespace Mytra.Business
{
    using Core;

    public partial class AnnounceManager
    {
        public async Task<AnnounceResponse> SelectAsync(AnnounceSelectDataTransfer Model)
        {
            List<Announce> DataSource = await UnitOfWork.Announce.SelectAsync(x => x.IsActive == true);
            List<AnnounceResponse> Response = Mapper.Map<List<AnnounceResponse>>(DataSource);

            return new AnnounceResponse
            {
                




            };
        }
    }
}