namespace Mytra.Service
{
    using Core;
    using FluentValidation;

    public class ManagementContactValidator : AbstractValidator<ManagementContact>
    {
        public ManagementContactValidator()
        {
            RuleFor(x => x.RegisterDate).NotEmpty().WithMessage("RegisterDate can not be null");
            RuleFor(x => x.UpdateDate).NotEmpty().WithMessage("UpdateDate can not be null");
            RuleFor(x => x.IsActive).NotEmpty().WithMessage("IsActive can not be null");
        }
    }
}