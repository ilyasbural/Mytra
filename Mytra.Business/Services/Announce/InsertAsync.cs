namespace Mytra.Business
{
    using Core;

    public partial class AnnounceManager
    {
        public async Task<AnnounceResponse> AddAsync(AnnounceInsertDataTransfer model)
        {
            Announce announceModel = Mapper.Map<Announce>(model);
            announceModel.Id = Guid.NewGuid();
            announceModel.RegisterDate = DateTime.Now;
            announceModel.UpdateDate = DateTime.Now;
            announceModel.IsActive = true;

            await UnitOfWork.Announce.AddAsync(announceModel);
            await UnitOfWork.SaveChangesAsync();

            return new AnnounceResponse { Announce = announceModel };
        }
    }
}