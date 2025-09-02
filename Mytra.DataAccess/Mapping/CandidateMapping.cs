namespace Mytra.DataAccess
{
	using Core;
	using Microsoft.EntityFrameworkCore;
	using Microsoft.EntityFrameworkCore.Metadata.Builders;

	public class CandidateMapping : IEntityTypeConfiguration<Candidate>
	{
		public void Configure(EntityTypeBuilder<Candidate> builder)
		{
			builder.Property(x => x.Id).HasColumnOrder(0);
			builder.Property(x => x.Email).HasColumnType("VARCHAR(100)").IsRequired(true).HasColumnOrder(1);
			builder.Property(x => x.Password).HasColumnType("VARCHAR(100)").IsRequired(true).HasColumnOrder(2);
			builder.Property(x => x.RegisterDate).HasColumnType("DATETIME").IsRequired(true).HasColumnOrder(3);
			builder.Property(x => x.UpdateDate).HasColumnType("DATETIME").IsRequired(true).HasColumnOrder(4);
			builder.Property(x => x.IsActive).HasColumnType("BIT").IsRequired(true).HasColumnOrder(5);
			builder.ToTable("Candidate");
		}
	}
}