namespace Mytra.Common
{
	public class LanguageResponse : Response<LanguageResponse>
	{
		public String Name { get; set; } = String.Empty;
		public LanguageResponse() { }
	}
}