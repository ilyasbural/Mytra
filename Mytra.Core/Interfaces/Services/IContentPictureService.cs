namespace Mytra.Core
{
    public interface IContentPictureService
    {
        Task<Response<ContentPicture>> InsertAsync(ContentPictureInsertDataTransfer Model);
        Task<Response<ContentPicture>> UpdateAsync(ContentPictureUpdateDataTransfer Model);
        Task<Response<ContentPicture>> DeleteAsync(ContentPictureDeleteDataTransfer Model);
        Task<Response<ContentPicture>> SelectAsync(ContentPictureSelectDataTransfer Model);
        Task<Response<ContentPicture>> AnySelectAsync(ContentPictureAnyDataTransfer Model);
    }
}