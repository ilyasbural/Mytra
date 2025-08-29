namespace Mytra.Common
{
    public class CandidateAuthenticationResponse : ServiceResponse<CandidateAuthenticationResponse>
    {
        public Guid Id { get; set; }
        public DateTime RegisterDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public bool IsActive { get; set; }

		public CandidateAuthenticationResponse()
        {
            
        }
    }
}