namespace Mytra.Core
{
    public interface IContentPictureService
    {
        Task<ContentPictureResponse> AddAsync(ContentPictureInsertDataTransfer Model);
        Task<ContentPictureResponse> UpdateAsync(ContentPictureUpdateDataTransfer Model);
        Task<ContentPictureResponse> DeleteAsync(ContentPictureDeleteDataTransfer Model);
        Task<ContentPictureResponse> SelectAsync(ContentPictureSelectDataTransfer Model);
        Task<ContentPictureResponse> AnyAsync(ContentPictureAnyDataTransfer Model);
    }
}