namespace Mytra.DataAccess
{
    public class ContentSettingsRepositoryEF : Core.BaseRepository<Core.ContentSettings>, Core.IContentSettings
    {
        public ContentSettingsRepositoryEF(Microsoft.EntityFrameworkCore.DbContext dbContext) : base(dbContext)
        {

        }
    }
}