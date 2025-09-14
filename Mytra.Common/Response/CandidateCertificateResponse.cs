namespace Mytra.Common
{
	public class CandidateCertificateResponse : Response<CandidateCertificateResponse>
	{
		public String Name { get; set; } = String.Empty;
		public CandidateCertificateResponse() { }
	}
}