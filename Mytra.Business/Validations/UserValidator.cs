namespace Mytra.Business
{
    using Core;
    using FluentValidation;

    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(x => x.Id).NotEmpty().WithMessage("Id can not be null");
            RuleFor(x => x.Username).NotEmpty().WithMessage("Username can not be null");
            RuleFor(x => x.Email).NotEmpty().WithMessage("Email can not be null");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Password can not be null");
            RuleFor(x => x.RegisterDate).NotEmpty().WithMessage("RegisterDate can not be null");
            RuleFor(x => x.UpdateDate).NotEmpty().WithMessage("UpdateDate can not be null");
            RuleFor(x => x.IsActive).NotEmpty().WithMessage("IsActive can not be null");
        }
    }
}