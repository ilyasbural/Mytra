namespace Mytra.Business
{
    using Core;

    public partial class AnnounceManager
    {
        public async Task<AnnounceResponse> InsertAsync(AnnounceInsertDataTransfer model)
        {
            Announce announceModel = Mapper.Map<Announce>(model);
            announceModel.Id = Guid.NewGuid();
            announceModel.RegisterDate = DateTime.Now;
            announceModel.UpdateDate = DateTime.Now;
            announceModel.IsActive = true;

            await UnitOfWork.Announce.InsertAsync(announceModel);
            await UnitOfWork.SaveChangesAsync();

            return new AnnounceResponse { Announce = announceModel };
        }
    }
}