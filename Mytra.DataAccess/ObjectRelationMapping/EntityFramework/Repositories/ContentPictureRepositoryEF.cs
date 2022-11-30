namespace Mytra.DataAccess
{
    public class ContentPictureRepositoryEF : BaseRepository<Core.ContentPicture>, Core.IContentPictureRepository
    {
        public ContentPictureRepositoryEF(Microsoft.EntityFrameworkCore.DbContext dbContext) : base(dbContext)
        {

        }
    }
}