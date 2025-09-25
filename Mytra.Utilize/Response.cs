namespace Mytra.Utilize
{
	public abstract class Response<T> where T : class
	{
		public Guid Id { get; set; }
		public DateTime RegisterDate { get; set; }
		public DateTime UpdateDate { get; set; }
		public bool IsActive { get; set; }
	}
}