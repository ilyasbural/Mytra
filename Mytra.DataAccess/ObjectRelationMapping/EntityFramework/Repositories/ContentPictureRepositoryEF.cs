namespace Mytra.DataAccess
{
    public class ContentPictureRepositoryEF : Core.BaseRepository<Core.ContentPicture>, Core.IContentPicture
    {
        public ContentPictureRepositoryEF(Microsoft.EntityFrameworkCore.DbContext dbContext) : base(dbContext)
        {

        }
    }
}