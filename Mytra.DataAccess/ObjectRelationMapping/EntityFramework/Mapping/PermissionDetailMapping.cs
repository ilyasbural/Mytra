namespace Mytra.DataAccess
{
    using Core;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class PermissionDetailMapping : IEntityTypeConfiguration<PermissionDetail>
    {
        public void Configure(EntityTypeBuilder<PermissionDetail> builder)
        {
            builder.Property(e => e.Permission).HasColumnName("PERMISSION");
            builder.Property(e => e.Id).HasColumnName("ID").ValueGeneratedNever();
            builder.Property(x => x.RegisterDate).HasColumnName("REGISTER DATE").HasColumnType("DATETIME");
            builder.Property(x => x.UpdateDate).HasColumnName("UPDATE DATE").HasColumnType("DATETIME");
            builder.Property(e => e.IsActive).HasColumnName("IS ACTIVE");
            builder.HasOne(d => d.PermissionNavigation).WithMany(p => p.PermissionDetails).HasForeignKey(d => d.Permission).HasConstraintName("FK_PERMISSION DETAIL_PERMISSION");
            builder.ToTable("PERMISSION DETAIL");
        }
    }
}