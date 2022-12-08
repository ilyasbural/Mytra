namespace Mytra.Business
{
    using Core;

    public partial class AnnounceManager 
    {
        public async Task<AnnounceResponse> AnyAsync(AnnounceAnyDataTransfer Model)
        {
            //Response.IsAvailable = await UnitOfWork.Announce.AnyAsync(x => x.Id == Model.Id);
            //Response.Message = "Found";
            //Response.IsSuccess = true;
            //return Response;

            await UnitOfWork.Announce.AnyAsync(x => x.Id == Model.Id);

            return new AnnounceResponse
            {
                


            };
        }
    }
}