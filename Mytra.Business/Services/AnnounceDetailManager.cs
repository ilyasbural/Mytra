namespace Mytra.Business
{
    using Core;
    using AutoMapper;
    using FluentValidation;
    using System.Threading.Tasks;
    using System.Collections.Generic;

    public partial class AnnounceDetailManager : BusinessObject<AnnounceDetail>, IAnnounceDetailService
    {
        readonly IMapper Mapper;
        readonly IUnitOfWork UnitOfWork;
        readonly IValidator<AnnounceDetail> Validator;

        public AnnounceDetailManager(IMapper mapper, IUnitOfWork unitOfWork, IValidator<AnnounceDetail> validator)
        {
            Mapper = mapper;
            UnitOfWork = unitOfWork;
            Validator = validator;
        }

        public async Task<AnnounceDetailResponse> InsertAsync(AnnounceDetailInsertDataTransfer Model)
        {
            AnnounceDetail announceDetail = Mapper.Map<AnnounceDetail>(Model);
            announceDetail.RegisterDate = DateTime.Now;
            announceDetail.UpdateDate = DateTime.Now;
            announceDetail.IsActive = true;

            await UnitOfWork.AnnounceDetail.InsertAsync(announceDetail);
            await UnitOfWork.SaveChangesAsync();

            return new AnnounceDetailResponse { AnnounceDetail = announceDetail };
        }

        public async Task<AnnounceDetailResponse> UpdateAsync(AnnounceDetailUpdateDataTransfer Model)
        {
            throw new NotImplementedException();
        }      

        public async Task<AnnounceDetailResponse> DeleteAsync(AnnounceDetailDeleteDataTransfer Model)
        {
            throw new NotImplementedException();
        }  

        public async Task<AnnounceDetailResponse> SelectAsync(AnnounceDetailSelectDataTransfer Model)
        {
            throw new NotImplementedException();
        }

        public async Task<AnnounceDetailResponse> AnyAsync(AnnounceDetailAnyDataTransfer Model)
        {
            throw new NotImplementedException();
        }
    }
}