namespace Mytra.Core
{
    using FluentValidation;
    using FluentValidation.Results;

    public abstract class BusinessObject<T> where T : class, IEntity, new()
    {
        public int Result { get; set; } = 0;
        public T Entity { get; set; } = null!;
        public int Success { get; set; } = 0;
        public string Message { get; set; } = null!;
        public bool IsValidationError { get; set; } = false;
        public ValidationResult Validations { get; set; } = null!;
    }
}