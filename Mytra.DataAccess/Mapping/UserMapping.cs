namespace Mytra.DataAccess
{
    using Core;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class UserMapping : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.Property(x => x.Id).HasColumnOrder(0);
			builder.Property(x => x.Email).HasColumnType("VARCHAR(100)").IsRequired(true).HasColumnOrder(1);
			//builder.Property(x => x.Password).HasColumnType("VARCHAR(100)").IsRequired(true).HasColumnOrder(2);
			builder.Property(x => x.RegisterDate).HasColumnType("DATETIME").IsRequired(true).HasColumnOrder(2);
            builder.Property(x => x.UpdateDate).HasColumnType("DATETIME").IsRequired(true).HasColumnOrder(3);
            builder.Property(x => x.IsActive).HasColumnType("BIT").IsRequired(true).HasColumnOrder(4);
            builder.ToTable("User");
        }
    }
}