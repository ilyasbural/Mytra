namespace Mytra.Core
{
    using FluentValidation;
    using FluentValidation.Results;

    public abstract class WebResponseBase<T> where T : class, IEntity, new()
    {
        public T Single { get; set; } = null!;
        public List<T> List { get; set; } = null!;
        public bool IsValidationError { get; set; }
        public List<ValidationResult> Validations { get; set; } = null!;
        public List<string> Errors { get; set; } = null!;
        public int Success { get; set; }
        public string Message { get; set; } = null!;
    }
}