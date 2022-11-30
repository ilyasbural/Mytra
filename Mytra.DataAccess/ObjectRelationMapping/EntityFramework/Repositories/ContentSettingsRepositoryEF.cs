namespace Mytra.DataAccess
{
    public class ContentSettingsRepositoryEF : BaseRepository<Core.ContentSettings>, Core.IContentSettingsRepository
    {
        public ContentSettingsRepositoryEF(Microsoft.EntityFrameworkCore.DbContext dbContext) : base(dbContext)
        {

        }
    }
}