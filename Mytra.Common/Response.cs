namespace Mytra.Common
{
	public abstract class Response<T> where T : class
	{
		public Guid Id { get; set; }
	}
}