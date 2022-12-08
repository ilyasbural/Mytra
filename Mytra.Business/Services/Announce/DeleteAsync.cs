namespace Mytra.Business
{
    using Core;

    public partial class AnnounceManager 
    {
        public async Task<AnnounceResponse> DeleteAsync(AnnounceDeleteDataTransfer Model)
        {
            List<Announce> DataSource = await UnitOfWork.Announce.SelectAsync(x => x.Id == Model.Id);
            Announce Entity = Mapper.Map<Announce>(DataSource[0]);

            await UnitOfWork.Announce.DeleteAsync(Entity);
            await UnitOfWork.SaveChangesAsync();

            AnnounceResponse Response = Mapper.Map<AnnounceResponse>(Entity);

            return new AnnounceResponse
            {
               


            };
        }
    }
}