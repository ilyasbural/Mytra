namespace Mytra.DataAccess
{
	using Core;
	using Microsoft.EntityFrameworkCore;
	using Microsoft.EntityFrameworkCore.Metadata.Builders;

	public class InstitutionMapping : IEntityTypeConfiguration<Institution>
	{
		public void Configure(EntityTypeBuilder<Institution> builder)
		{
			builder.Property(x => x.Id).HasColumnOrder(0);
			builder.Property(x => x.Name).HasColumnType("NVARCHAR(100)").IsRequired(false).HasColumnOrder(1);
			builder.Property(x => x.RegisterDate).HasColumnType("DATETIME").IsRequired(true).HasColumnOrder(2);
			builder.Property(x => x.UpdateDate).HasColumnType("DATETIME").IsRequired(true).HasColumnOrder(3);
			builder.Property(x => x.IsActive).HasColumnType("BIT").IsRequired(true).HasColumnOrder(4);
			builder.ToTable("Institution");
		}
	}
}