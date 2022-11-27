namespace Mytra.DataAccess
{
    using Core;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class ContentMapping : IEntityTypeConfiguration<Content>
    {
        public void Configure(EntityTypeBuilder<Content> builder)
        {
            builder.Property(e => e.Id).HasColumnName("ID").ValueGeneratedNever();
            builder.Property(e => e.Category).HasColumnName("CATEGORY");
            builder.Property(e => e.ContentType).HasColumnName("CONTENT TYPE");
            builder.Property(x => x.RegisterDate).HasColumnName("REGISTER DATE").HasColumnType("DATETIME");
            builder.Property(x => x.UpdateDate).HasColumnName("UPDATE DATE").HasColumnType("DATETIME");
            builder.Property(e => e.IsActive).HasColumnName("IS ACTIVE");
            builder.HasOne(d => d.CategoryNavigation).WithMany(p => p.Contents).HasForeignKey(d => d.Category).HasConstraintName("FK_CONTENT_CATEGORY");
            builder.HasOne(d => d.ContentTypeNavigation).WithMany(p => p.Contents).HasForeignKey(d => d.ContentType).HasConstraintName("FK_CONTENT_CONTENT TYPE");
            builder.ToTable("CONTENT");
        }
    }
}