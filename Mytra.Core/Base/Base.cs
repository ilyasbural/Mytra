namespace Mytra.Core
{
    public abstract class Base<T> where T : Base<T>, new()
    {
        public Guid Id { get; set; }
        public DateTime RegisterDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public bool IsActive { get; set; }
    }
}