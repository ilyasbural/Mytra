namespace Mytra.Common
{
	public class ValueResponse<T>
	{
		public Guid Id { get; set; }
		public DateTime RegisterDate { get; set; }
		public DateTime UpdateDate { get; set; }
		public bool IsActive { get; set; }
		public ValueResponse() {  }
	}
}