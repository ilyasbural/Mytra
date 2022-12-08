namespace Mytra.Business
{
    using Core;
    using AutoMapper;
    using FluentValidation;

    public partial class AnnounceManager : BusinessObject<Announce>, IAnnounceService
    {
        readonly IMapper Mapper;
        readonly IUnitOfWork UnitOfWork;
        readonly IValidator<Announce> Validator;

        public AnnounceManager(IMapper mapper, IUnitOfWork unitOfWork, IValidator<Announce> validator)
        {
            Mapper = mapper;
            UnitOfWork = unitOfWork;
            Validator = validator;
        }
    }
}