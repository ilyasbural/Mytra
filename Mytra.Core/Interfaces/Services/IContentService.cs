namespace Mytra.Core
{
    public interface IContentService
    {
        Task<ContentResponse> AddAsync(ContentInsertDataTransfer Model);
        Task<ContentResponse> UpdateAsync(ContentUpdateDataTransfer Model);
    }
}