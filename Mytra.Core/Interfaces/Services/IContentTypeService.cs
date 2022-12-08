namespace Mytra.Core
{
    public interface IContentTypeService
    {
        Task<ContentTypeResponse> InsertAsync(ContentTypeInsertDataTransfer Model);
        Task<ContentTypeResponse> UpdateAsync(ContentTypeUpdateDataTransfer Model);
        Task<ContentTypeResponse> DeleteAsync(ContentTypeDeleteDataTransfer Model);
        Task<ContentTypeResponse> SelectAsync(ContentTypeSelectDataTransfer Model);
        Task<ContentTypeResponse> AnyAsync(ContentTypeAnyDataTransfer Model);
    }
}