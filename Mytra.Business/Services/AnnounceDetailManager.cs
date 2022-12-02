namespace Mytra.Business
{
    using Core;
    using AutoMapper;
    using FluentValidation;
    using System.Threading.Tasks;
    using System.Collections.Generic;

    public class AnnounceDetailManager : BusinessObject<AnnounceDetail>, IAnnounceDetailService
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

        public async Task<AnnounceDetailResponse> AddAsync(AnnounceDetailInsertDataTransfer Model)
        {
            AnnounceDetail announceDetail = Mapper.Map<AnnounceDetail>(Model);
            announceDetail.Id = Guid.NewGuid();
            announceDetail.RegisterDate = DateTime.Now;
            announceDetail.UpdateDate = DateTime.Now;
            announceDetail.IsActive = true;

            await UnitOfWork.AnnounceDetail.AddAsync(announceDetail);
            await UnitOfWork.SaveChangesAsync();

            return new AnnounceDetailResponse
            {
                //Data = Entity,
                //Response = Mapper.Map<AbilityDataTransferInsert>(Entity)
            };
        }

        public async Task<AnnounceDetailResponse> UpdateAsync(AnnounceDetailUpdateDataTransfer Model)
        {
            AnnounceDetail announceDetail = Mapper.Map<AnnounceDetail>(Model);
            announceDetail.Id = Guid.NewGuid();
            announceDetail.RegisterDate = DateTime.Now;
            announceDetail.UpdateDate = DateTime.Now;
            announceDetail.IsActive = true;

            await UnitOfWork.AnnounceDetail.UpdateAsync(announceDetail);
            await UnitOfWork.SaveChangesAsync();

            return new AnnounceDetailResponse
            {
                //Data = Entity,
                //Response = Mapper.Map<AbilityDataTransferInsert>(Entity)
            };
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