namespace Mytra.DataAccess
{
    using Core;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class UserDetailMapping : IEntityTypeConfiguration<UserDetail>
    {
        public void Configure(EntityTypeBuilder<UserDetail> builder)
        {
            builder.Property(e => e.Id).ValueGeneratedNever().HasColumnName("ID");
            builder.Property(x => x.RegisterDate).HasColumnName("REGISTER DATE").HasColumnType("DATETIME");
            builder.Property(x => x.UpdateDate).HasColumnName("UPDATE DATE").HasColumnType("DATETIME");
            builder.Property(e => e.IsActive).HasColumnName("IS ACTIVE");
            builder.HasOne(d => d.IdNavigation).WithOne(p => p.UserDetail).HasForeignKey<UserDetail>(d => d.Id).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_USER DETAIL_USER");
            builder.ToTable("USER DETAIL");
        }
    }
}