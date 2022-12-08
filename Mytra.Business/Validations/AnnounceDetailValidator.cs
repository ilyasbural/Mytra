namespace Mytra.Business
{
    using Core;
    using FluentValidation;

    public class AnnounceDetailValidator : AbstractValidator<AnnounceDetail>
    {
        public AnnounceDetailValidator()
        {
            RuleFor(x => x.Detail).NotEmpty().WithMessage("Detail can not be null").Length(0, 250).WithMessage("Detail should have 750 chars at most");
            RuleFor(x => x.RegisterDate).NotEmpty().WithMessage("RegisterDate can not be null");
            RuleFor(x => x.UpdateDate).NotEmpty().WithMessage("UpdateDate can not be null");
            RuleFor(x => x.IsActive).NotEmpty().WithMessage("IsActive can not be null");
        }
    }
}