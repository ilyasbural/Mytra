namespace Mytra.Core
{
    public class SurveyDetailWebResponse : BaseWebResponse<SurveyDetailWebResponse>
    {
        public SurveyDetail SurveyDetail { get; set; } = null!;
    }
}