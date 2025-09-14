namespace Mytra.Common
{
	public class CandidatePhotoResponse : Response<CandidatePhotoResponse>
	{
		public String Name { get; set; } = String.Empty;
		public DateTime RegisterDate { get; set; }
		public DateTime UpdateDate { get; set; }
		public bool IsActive { get; set; }
		public CandidatePhotoResponse() { }
	}
}