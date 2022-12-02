namespace Mytra.Core
{
    public interface IContentTypeService
    {
        Task<ContentTypeResponse> AddAsync(ContentTypeInsertDataTransfer Model);
        Task<ContentTypeResponse> UpdateAsync(ContentTypeUpdateDataTransfer Model);
    }
}