namespace Mytra.Business
{
    using Core;
    using FluentValidation;

    public class UserSettingsValidator : AbstractValidator<UserSettings>
    {
        public UserSettingsValidator()
        {
            //RuleFor(x => x.Name).NotEmpty().WithMessage("Name can not be null").Length(0, 50).WithMessage("Name should have 50 chars at most");
            //RuleFor(x => x.RegisterDate).NotEmpty().WithMessage("RegisterDate can not be null");
            //RuleFor(x => x.UpdateDate).NotEmpty().WithMessage("UpdateDate can not be null");
            //RuleFor(x => x.IsActive).NotEmpty().WithMessage("IsActive can not be null");
        }
    }
}