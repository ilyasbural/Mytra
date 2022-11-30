namespace Mytra.Core
{
    public interface IContentTypeService
    {
        Task<ContentTypeResponse> AddAsync(ContentTypeInsertDataTransfer Model);
    }
}