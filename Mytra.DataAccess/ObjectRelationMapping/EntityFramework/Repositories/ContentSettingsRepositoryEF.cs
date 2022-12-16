namespace Mytra.DataAccess
{
    public class ContentSettingsRepositoryEF : RepositoryBase<Core.ContentSettings>, Core.IContentSettingsRepository
    {
        public ContentSettingsRepositoryEF(Microsoft.EntityFrameworkCore.DbContext dbContext) : base(dbContext)
        {

        }
    }
}