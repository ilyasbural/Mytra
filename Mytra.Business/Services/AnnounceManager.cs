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

        public async Task<AnnounceResponse> InsertAsync(AnnounceInsertDataTransfer model)
        {
            Announce announceModel = Mapper.Map<Announce>(model);
            announceModel.Id = Guid.NewGuid();
            announceModel.RegisterDate = DateTime.Now;
            announceModel.UpdateDate = DateTime.Now;
            announceModel.IsActive = true;

            await UnitOfWork.Announce.InsertAsync(announceModel);
            await UnitOfWork.SaveChangesAsync();

            return new AnnounceResponse { Announce = announceModel };
        }

        public async Task<AnnounceResponse> UpdateAsync(AnnounceUpdateDataTransfer Model)
        {
            throw new NotImplementedException();
        }

        public async Task<AnnounceResponse> DeleteAsync(AnnounceDeleteDataTransfer Model)
        {
            throw new NotImplementedException();
        }

        public async Task<AnnounceResponse> SelectAsync(AnnounceSelectDataTransfer Model)
        {
            throw new NotImplementedException();
        }  

        public async Task<AnnounceResponse> AnyAsync(AnnounceAnyDataTransfer Model)
        {
            throw new NotImplementedException();
        }
    }
}