namespace Mytra.Common
{
    public class CandidateAuthenticationResponse : ServiceResponse<CandidateAuthenticationResponse>
    {
        public String Name { get; set; } = String.Empty;

		public CandidateAuthenticationResponse()
        {
            
        }
    }
}