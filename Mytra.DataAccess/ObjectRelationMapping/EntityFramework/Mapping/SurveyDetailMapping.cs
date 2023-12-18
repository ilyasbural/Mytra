namespace Mytra.DataAccess
{
    using Core;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class SurveyDetailMapping : IEntityTypeConfiguration<SurveyDetail>
    {
        public void Configure(EntityTypeBuilder<SurveyDetail> builder)
        {
            builder.Property(e => e.Survey).HasColumnName("SURVEY");
            builder.Property(e => e.User).HasColumnName("USER");
            builder.Property(e => e.Id).HasColumnName("ID").ValueGeneratedNever();
            builder.Property(x => x.RegisterDate).HasColumnName("REGISTER DATE").HasColumnType("DATETIME");
            builder.Property(x => x.UpdateDate).HasColumnName("UPDATE DATE").HasColumnType("DATETIME");
            builder.Property(e => e.IsActive).HasColumnName("IS ACTIVE");
            builder.HasOne(d => d.SurveyNavigation).WithMany(p => p.SurveyDetails).HasForeignKey(d => d.Survey).HasConstraintName("FK_SURVEY DETAIL_SURVEY");
            builder.HasOne(d => d.UserNavigation).WithMany(p => p.SurveyDetails).HasForeignKey(d => d.User).HasConstraintName("FK_SURVEY DETAIL_USER");
            builder.ToTable("SURVEY DETAIL");
        }
    }
}