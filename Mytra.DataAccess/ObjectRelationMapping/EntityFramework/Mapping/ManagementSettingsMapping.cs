namespace Mytra.DataAccess
{
    using Core;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class ManagementSettingsMapping : IEntityTypeConfiguration<ManagementSettings>
    {
        public void Configure(EntityTypeBuilder<ManagementSettings> builder)
        {
            builder.Property(e => e.Id).HasColumnName("ID").ValueGeneratedNever();
            builder.Property(x => x.RegisterDate).HasColumnName("REGISTER DATE").HasColumnType("DATETIME");
            builder.Property(x => x.UpdateDate).HasColumnName("UPDATE DATE").HasColumnType("DATETIME");
            builder.Property(e => e.IsActive).HasColumnName("IS ACTIVE");
            builder.HasOne(d => d.IdNavigation).WithOne(p => p.ManagementSetting).HasForeignKey<ManagementSettings>(d => d.Id).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_MANAGEMENT SETTINGS_MANAGEMENT");
            builder.ToTable("MANAGEMENT SETTINGS");
        }
    }
}