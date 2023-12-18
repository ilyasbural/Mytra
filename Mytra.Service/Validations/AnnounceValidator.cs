namespace Mytra.Service
{
    using Core;
    using FluentValidation;

    public class AnnounceValidator : AbstractValidator<Announce>
    {
        public AnnounceValidator()
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage("Title can not be null").Length(0, 250).WithMessage("Title should have 250 chars at most");
            RuleFor(x => x.RegisterDate).NotEmpty().WithMessage("RegisterDate can not be null");
            RuleFor(x => x.UpdateDate).NotEmpty().WithMessage("UpdateDate can not be null");
            RuleFor(x => x.IsActive).NotEmpty().WithMessage("IsActive can not be null");
        }
    }
}