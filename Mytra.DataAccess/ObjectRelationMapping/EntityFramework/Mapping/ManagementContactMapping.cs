namespace Mytra.DataAccess
{
    using Core;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class ManagementContactMapping : IEntityTypeConfiguration<ManagementContact>
    {
        public void Configure(EntityTypeBuilder<ManagementContact> builder)
        {
            builder.Property(e => e.Management).HasColumnName("MANAGEMENT");
            builder.Property(e => e.Id).ValueGeneratedNever().HasColumnName("ID");
            builder.Property(x => x.RegisterDate).HasColumnName("REGISTER DATE").HasColumnType("DATETIME");
            builder.Property(x => x.UpdateDate).HasColumnName("UPDATE DATE").HasColumnType("DATETIME");
            builder.Property(e => e.IsActive).HasColumnName("IS ACTIVE");
            builder.HasOne(d => d.ManagementNavigation).WithMany(p => p.ManagementContacts).HasForeignKey(d => d.Management).HasConstraintName("FK_MANAGEMENT CONTACT_MANAGEMENT");
            builder.ToTable("MANAGEMENT CONTACT");
        }
    }
}