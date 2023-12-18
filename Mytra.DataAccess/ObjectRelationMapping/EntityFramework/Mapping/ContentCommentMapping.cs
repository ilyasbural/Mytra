namespace Mytra.DataAccess
{
    using Core;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class ContentCommentMapping : IEntityTypeConfiguration<ContentComment>
    {
        public void Configure(EntityTypeBuilder<ContentComment> builder)
        {
            builder.Property(e => e.Content).HasColumnName("CONTENT");
            builder.Property(e => e.User).HasColumnName("USER");
            builder.Property(e => e.Id).HasColumnName("ID").ValueGeneratedNever();
            builder.Property(x => x.RegisterDate).HasColumnName("REGISTER DATE").HasColumnType("DATETIME");
            builder.Property(x => x.UpdateDate).HasColumnName("UPDATE DATE").HasColumnType("DATETIME");
            builder.Property(e => e.IsActive).HasColumnName("IS ACTIVE");
            builder.HasOne(d => d.ContentNavigation).WithMany(p => p.ContentComments).HasForeignKey(d => d.Content).HasConstraintName("FK_CONTENT COMMENT_CONTENT");
            builder.HasOne(d => d.UserNavigation).WithMany(p => p.ContentComments).HasForeignKey(d => d.User).HasConstraintName("FK_CONTENT COMMENT_USER");
            builder.ToTable("CONTENT COMMENT");
        }
    }
}