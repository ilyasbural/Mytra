namespace Mytra.Common
{
	public abstract class ServiceResponse<T>
	{
		public T ResponseData { get; set; } = default(T)!;
		public List<T> ResponseDataSource { get; set; } = new List<T>();
		public int Success { get; set; }

		public ServiceResponse() { }
	}
}