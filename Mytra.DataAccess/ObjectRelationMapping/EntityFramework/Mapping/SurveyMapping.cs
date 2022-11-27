namespace Mytra.DataAccess
{
    using Core;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class SurveyMapping : IEntityTypeConfiguration<Survey>
    {
        public void Configure(EntityTypeBuilder<Survey> builder)
        {
            builder.Property(e => e.Sub).HasColumnName("SUB");
            builder.Property(e => e.Id).ValueGeneratedNever().HasColumnName("ID");
            builder.Property(e => e.Question).HasMaxLength(250).HasColumnName("QUESTION");
            builder.Property(x => x.RegisterDate).HasColumnName("REGISTER DATE").HasColumnType("DATETIME");
            builder.Property(x => x.UpdateDate).HasColumnName("UPDATE DATE").HasColumnType("DATETIME");
            builder.Property(e => e.IsActive).HasColumnName("IS ACTIVE");
            builder.HasOne(d => d.SubNavigation).WithMany(p => p.InverseSubNavigation).HasForeignKey(d => d.Sub).HasConstraintName("FK_SURVEY_SURVEY");
            builder.ToTable("SURVEY");
        }
    }
}