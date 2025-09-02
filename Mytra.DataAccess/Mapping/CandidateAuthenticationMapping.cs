namespace Mytra.DataAccess
{
	using Core;
	using Microsoft.EntityFrameworkCore;
	using Microsoft.EntityFrameworkCore.Metadata.Builders;

	public class CandidateAuthenticationMapping : IEntityTypeConfiguration<CandidateAuthentication>
	{
		public void Configure(EntityTypeBuilder<CandidateAuthentication> builder)
		{
			builder.Property(x => x.Id).HasColumnOrder(0);
			builder.Property(x => x.RefreshToken).HasColumnType("VARCHAR(200)").IsRequired(true).HasColumnOrder(1);
			builder.Property(x => x.RefreshTokenExpireTime).HasColumnType("DATETIME").IsRequired(true).HasColumnOrder(2);
			builder.Property(x => x.RegisterDate).HasColumnType("DATETIME").IsRequired(true).HasColumnOrder(3);
			builder.Property(x => x.UpdateDate).HasColumnType("DATETIME").IsRequired(true).HasColumnOrder(4);
			builder.Property(x => x.IsActive).HasColumnType("BIT").IsRequired(true).HasColumnOrder(5);
			builder.ToTable("CandidateAuthentication");
		}
	}
}