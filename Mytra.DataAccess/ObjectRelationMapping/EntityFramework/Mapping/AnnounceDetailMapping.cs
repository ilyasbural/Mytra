namespace Mytra.DataAccess
{
    using Core;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class AnnounceDetailMapping : IEntityTypeConfiguration<AnnounceDetail>
    {
        public void Configure(EntityTypeBuilder<AnnounceDetail> builder)
        {
            builder.Property(e => e.Announce).HasColumnName("ANNOUNCE");
            builder.Property(e => e.Id).HasColumnName("ID").ValueGeneratedNever();
            builder.Property(e => e.Detail).HasColumnName("DETAIL").HasMaxLength(750);
            builder.Property(x => x.RegisterDate).HasColumnName("REGISTER DATE").HasColumnType("DATETIME");
            builder.Property(x => x.UpdateDate).HasColumnName("UPDATE DATE").HasColumnType("DATETIME");
            builder.Property(e => e.IsActive).HasColumnName("IS ACTIVE");
            builder.HasOne(d => d.AnnounceNavigation).WithMany(p => p.AnnounceDetails).HasForeignKey(d => d.Announce).HasConstraintName("FK_ANNOUNCE DETAIL_ANNOUNCE");
            builder.ToTable("ANNOUNCE DETAIL");
        }
    }
}