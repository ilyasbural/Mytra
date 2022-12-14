namespace Mytra.Core
{
    public abstract class ServiceResponseBase<T> where T : class, IEntity, new()
    {
        public T Single { get; set; } = null!;
        public List<T> List { get; set; } = null!;
        public int Success { get; set; }
        public string Message { get; set; } = null!;
    }
}