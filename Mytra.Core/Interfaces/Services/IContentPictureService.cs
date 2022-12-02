namespace Mytra.Core
{
    public interface IContentPictureService
    {
        Task<ContentPictureResponse> AddAsync(ContentPictureInsertDataTransfer Model);
        Task<ContentPictureResponse> UpdateAsync(ContentPictureUpdateDataTransfer Model);
    }
}