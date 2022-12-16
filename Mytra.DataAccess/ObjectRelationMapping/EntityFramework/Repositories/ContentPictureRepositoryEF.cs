namespace Mytra.DataAccess
{
    public class ContentPictureRepositoryEF : RepositoryBase<Core.ContentPicture>, Core.IContentPictureRepository
    {
        public ContentPictureRepositoryEF(Microsoft.EntityFrameworkCore.DbContext dbContext) : base(dbContext)
        {

        }
    }
}