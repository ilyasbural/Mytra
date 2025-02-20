namespace Mytra.Common
{
    public class Response<T>
    {
        public T ResponseData { get; set; } = default(T)!;
        public List<T> ResponseDataSource { get; set; } = new List<T>();
        //public List<ValidationError> Errors { get; set; } = null!;
        //public AuthenticationInfo Authentication { get; set; } = new();
        public int Success { get; set; }

        public Response()
        {

        }
    }
}