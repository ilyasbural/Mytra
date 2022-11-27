namespace Mytra.DataAccess
{
    using Core;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class UserMapping : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.Property(e => e.Id).HasColumnName("ID").ValueGeneratedNever();
            builder.Property(e => e.Username).HasColumnName("USERNAME").HasMaxLength(50);
            builder.Property(e => e.Email).HasMaxLength(50).IsUnicode(false).HasColumnName("EMAIL");
            builder.Property(e => e.Password).HasMaxLength(50).HasColumnName("PASSWORD");            
            builder.Property(e => e.RefreshToken).HasMaxLength(50).HasColumnName("REFRESH TOKEN");
            builder.Property(e => e.RefreshValidDate).HasColumnType("DATETIME").HasColumnName("REFRESH VALID DATE");
            builder.Property(x => x.RegisterDate).HasColumnName("REGISTER DATE").HasColumnType("DATETIME");
            builder.Property(x => x.UpdateDate).HasColumnName("UPDATE DATE").HasColumnType("DATETIME");
            builder.Property(e => e.IsActive).HasColumnName("IS ACTIVE");
            builder.ToTable("USER");
        }
    }
}