﻿namespace Mytra.DataAccess
{
	using Core;
	using Microsoft.EntityFrameworkCore;
	using Microsoft.EntityFrameworkCore.Metadata.Builders;

	public class ManagerAuthenticationMapping : IEntityTypeConfiguration<ManagerAuthentication>
	{
		public void Configure(EntityTypeBuilder<ManagerAuthentication> builder)
		{
			builder.Property(x => x.Id).HasColumnOrder(0);
			builder.Property(x => x.RegisterDate).HasColumnType("DATETIME").IsRequired(true).HasColumnOrder(1);
			builder.Property(x => x.UpdateDate).HasColumnType("DATETIME").IsRequired(true).HasColumnOrder(2);
			builder.Property(x => x.IsActive).HasColumnType("BIT").IsRequired(true).HasColumnOrder(3);
			builder.ToTable("ManagerAuthentication");
		}
	}
}