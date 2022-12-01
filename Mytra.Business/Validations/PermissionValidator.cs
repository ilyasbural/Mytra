namespace Mytra.Business
{
    using Core;
    using FluentValidation;

    public class PermissionValidator : AbstractValidator<Permission>
    {
        public PermissionValidator()
        {
            //RuleFor(x => x.Email).NotEmpty().WithMessage("Email required").EmailAddress().WithMessage("Please enter correct email format");
            //RuleFor(x => x.Password).NotEmpty().WithMessage("Password required").Length(0, 20).WithMessage("Password should have 20 chars at most");
            //RuleFor(x => x.RegisterDate).NotEmpty().WithMessage("RegisterDate can not be null");
            //RuleFor(x => x.UpdateDate).NotEmpty().WithMessage("UpdateDate can not be null");
            //RuleFor(x => x.IsActive).NotEmpty().WithMessage("IsActive can not be null");
        }
    }
}