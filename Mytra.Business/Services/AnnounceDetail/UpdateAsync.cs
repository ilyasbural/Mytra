namespace Mytra.Business
{
    using Core;

    public partial class AnnounceDetailManager
    {
        public async Task<AnnounceDetailResponse> UpdateAsync(AnnounceDetailUpdateDataTransfer Model)
        {
            AnnounceDetail announceDetail = Mapper.Map<AnnounceDetail>(Model);
            announceDetail.Id = Guid.NewGuid();
            announceDetail.RegisterDate = DateTime.Now;
            announceDetail.UpdateDate = DateTime.Now;
            announceDetail.IsActive = true;

            await UnitOfWork.AnnounceDetail.UpdateAsync(announceDetail);
            await UnitOfWork.SaveChangesAsync();

            return new AnnounceDetailResponse
            {
                



            };
        }
    }
}