namespace Mytra.Core
{
    public class Survey : Base<Survey>
    {
        public Guid? Sub { get; set; }
        public string? Question { get; set; }
        public virtual ICollection<Survey> InverseSubNavigation { get; } = new List<Survey>();
        public virtual Survey? SubNavigation { get; set; }
        public virtual ICollection<SurveyDetail> SurveyDetails { get; } = new List<SurveyDetail>();
    }
}