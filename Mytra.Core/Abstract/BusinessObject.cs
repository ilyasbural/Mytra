namespace Mytra.Core
{
    public abstract class ServiceObject<T> where T : class, IEntity, new()
    {
        protected int Result { get; set; } = 0;
        protected T Entity { get; set; } = null!;
        protected List<T> Collection { get; set; } = null!;
        protected int Success { get; set; } = 0;
        protected string Message { get; set; } = null!;
        protected bool IsValidationError { get; set; } = false;
    }
}