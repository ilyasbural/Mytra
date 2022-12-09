namespace Mytra.Business
{
    using Core;

    public partial class ContentManager
    {
        public async Task<ContentResponse> InsertAsync(ContentInsertDataTransfer Model)
        {
            Content content = Mapper.Map<Content>(Model);
            content.Id = Guid.NewGuid();
            content.RegisterDate = DateTime.Now;
            content.UpdateDate = DateTime.Now;
            content.IsActive = true;

            await UnitOfWork.Content.InsertAsync(content);
            await UnitOfWork.SaveChangesAsync();

            return new ContentResponse { Content = content };
        }
    }
}