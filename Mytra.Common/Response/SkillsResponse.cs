namespace Mytra.Common
{
	public class SkillsResponse : Response<SkillsResponse>
	{
		public String Name { get; set; } = String.Empty;
		public DateTime RegisterDate { get; set; }
		public DateTime UpdateDate { get; set; }
		public bool IsActive { get; set; }
		public SkillsResponse() { }
	}
}