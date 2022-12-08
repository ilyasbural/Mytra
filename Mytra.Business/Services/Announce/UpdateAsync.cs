namespace Mytra.Business
{
    using Core;

    public partial class AnnounceManager 
    {
        public async Task<AnnounceResponse> UpdateAsync(AnnounceUpdateDataTransfer Model)
        {
            List<Announce> DataSource = await UnitOfWork.Announce.SelectAsync(x => x.Id == Model.Id);
            Announce Entity = Mapper.Map<Announce>(DataSource[0]);
            Entity.Title = Model.Title;
            Entity.UpdateDate = DateTime.Now;

            await UnitOfWork.Announce.UpdateAsync(Entity);
            await UnitOfWork.SaveChangesAsync();

            AnnounceResponse Response = Mapper.Map<AnnounceResponse>(Entity);

            return new AnnounceResponse
            {
                Announce = Entity
            };
        }
    }
}