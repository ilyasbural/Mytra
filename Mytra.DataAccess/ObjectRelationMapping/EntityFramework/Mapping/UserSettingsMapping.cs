namespace Mytra.DataAccess
{
    using Core;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class UserSettingsMapping : IEntityTypeConfiguration<UserSettings>
    {
        public void Configure(EntityTypeBuilder<UserSettings> builder)
        {
            builder.Property(e => e.Id).HasColumnName("ID").ValueGeneratedNever();
            builder.Property(x => x.RegisterDate).HasColumnName("REGISTER DATE").HasColumnType("DATETIME").IsRequired(false);
            builder.Property(x => x.UpdateDate).HasColumnName("UPDATE DATE").HasColumnType("DATETIME").IsRequired(false);
            builder.Property(e => e.IsActive).HasColumnName("IS ACTIVE");
            builder.HasOne(d => d.IdNavigation).WithOne(p => p.UserSettings).HasForeignKey<UserSettings>(d => d.Id).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_USER SETTINGS_USER");
            builder.ToTable("USER SETTINGS");
        }
    }
}