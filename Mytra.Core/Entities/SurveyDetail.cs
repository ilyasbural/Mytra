namespace Mytra.Core
{
    public class SurveyDetail : Base<SurveyDetail>
    {
        public Guid? Survey { get; set; }
        public Guid? User { get; set; }
        public virtual Survey? SurveyNavigation { get; set; }
        public virtual User? UserNavigation { get; set; }
    }
}