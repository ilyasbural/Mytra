namespace Mytra.DataAccess
{
    using Core;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class ContentPictureMapping : IEntityTypeConfiguration<ContentPicture>
    {
        public void Configure(EntityTypeBuilder<ContentPicture> builder)
        {
            builder.Property(e => e.Content).HasColumnName("CONTENT");
            builder.Property(e => e.Id).HasColumnName("ID").ValueGeneratedNever();
            builder.Property(x => x.RegisterDate).HasColumnName("REGISTER DATE").HasColumnType("DATETIME");
            builder.Property(x => x.UpdateDate).HasColumnName("UPDATE DATE").HasColumnType("DATETIME");
            builder.Property(e => e.IsActive).HasColumnName("IS ACTIVE");
            builder.HasOne(d => d.ContentNavigation).WithMany(p => p.ContentPictures).HasForeignKey(d => d.Content).HasConstraintName("FK_CONTENT PICTURE_CONTENT");
            builder.ToTable("CONTENT PICTURE");
        }
    }
}