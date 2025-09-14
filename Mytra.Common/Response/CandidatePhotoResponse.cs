namespace Mytra.Common
{
	public class CandidatePhotoResponse : Response<CandidatePhotoResponse>
	{
		public String Name { get; set; } = String.Empty;
		public CandidatePhotoResponse() { }
	}
}