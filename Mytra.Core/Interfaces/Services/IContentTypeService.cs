namespace Mytra.Core
{
    public interface IContentTypeService
    {
        Task<Response<ContentType>> InsertAsync(ContentTypeInsertDataTransfer Model);
        Task<Response<ContentType>> UpdateAsync(ContentTypeUpdateDataTransfer Model);
        Task<Response<ContentType>> DeleteAsync(ContentTypeDeleteDataTransfer Model);
        Task<Response<ContentType>> SelectAsync(ContentTypeSelectDataTransfer Model);
        Task<Response<ContentType>> AnySelectAsync(ContentTypeAnyDataTransfer Model);
    }
}