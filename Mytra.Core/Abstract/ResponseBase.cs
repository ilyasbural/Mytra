namespace Mytra.Core
{
    public abstract class ResponseBase<T>
    {
        public T Data { get; set; }
        public List<T> Collection { get; set; } = null!;
        public bool IsValidationError { get; set; }
        public List<FluentValidation.Results.ValidationResult> Validations { get; set; } = null!;
        public List<string> Errors { get; set; } = null!;
        public int Success { get; set; } = 0;
        public string Message { get; set; } = null!;
    }
}