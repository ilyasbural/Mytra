namespace Mytra.Common
{
    public class CandidateResponse : ServiceResponse<CandidateResponse>
    {
        public String Name { get; set; } = String.Empty;

		public CandidateResponse()
        {
            
        }
    }
}