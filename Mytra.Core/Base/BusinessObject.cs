namespace Mytra.Core
{
    public class BusinessObject<T>
    {
        protected T Data { get; set; } = default!;
        protected List<T> Collection { get; set; } = null!;
        protected int Success { get; set; }

        public BusinessObject()
        {

        }
    }
}