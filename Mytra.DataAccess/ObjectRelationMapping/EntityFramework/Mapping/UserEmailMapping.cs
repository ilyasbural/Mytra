namespace Mytra.DataAccess
{
    using Core;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class UserEmailMapping : IEntityTypeConfiguration<UserEmail>
    {
        public void Configure(EntityTypeBuilder<UserEmail> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.RegisterDate);
            builder.Property(x => x.UpdateDate);
            builder.Property(x => x.IsActive);
        }
    }
}