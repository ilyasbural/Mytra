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
            announceDetail.Id = Guid.NewGuid();
            announceDetail.RegisterDate = DateTime.Now;
            announceDetail.UpdateDate = DateTime.Now;
            announceDetail.IsActive = true;

            await UnitOfWork.AnnounceDetail.InsertAsync(announceDetail);
            int result = await UnitOfWork.SaveChangesAsync();

            return new AnnounceDetailResponse 
            { 
                Single = announceDetail, 
                Success = result, 
                Message = "Completed"
            };
        }

        public async Task<AnnounceDetailResponse> UpdateAsync(AnnounceDetailUpdateDataTransfer Model)
        {
            List<AnnounceDetail> DataSource = await UnitOfWork.AnnounceDetail.SelectAsync(x => x.Id == Model.Id);
            AnnounceDetail picture = Mapper.Map<AnnounceDetail>(DataSource[0]);
            picture.UpdateDate = DateTime.Now;

            await UnitOfWork.AnnounceDetail.UpdateAsync(picture);
            int result = await UnitOfWork.SaveChangesAsync();

            return new AnnounceDetailResponse 
            { 
                Single = picture, 
                Success = result, 
                Message = "Completed"
            };
        }      

        public async Task<AnnounceDetailResponse> DeleteAsync(AnnounceDetailDeleteDataTransfer Model)
        {
            List<AnnounceDetail> announceDetailDataSource = await UnitOfWork.AnnounceDetail.SelectAsync(x => x.Id == Model.Id);
            AnnounceDetail announceDetail = Mapper.Map<AnnounceDetail>(announceDetailDataSource[0]);

            await UnitOfWork.AnnounceDetail.DeleteAsync(announceDetail);
            int result = await UnitOfWork.SaveChangesAsync();

            return new AnnounceDetailResponse
            {
                Single = announceDetail,
                Success = result,
                Message = "Completed"
            };
        }  

        public async Task<AnnounceDetailResponse> SelectAsync(AnnounceDetailSelectDataTransfer Model)
        {
            List<AnnounceDetail> announceDetailDataSource = await UnitOfWork.AnnounceDetail.SelectAsync(x => x.IsActive == true);
            return new AnnounceDetailResponse
            {
                List = announceDetailDataSource, 
                Success = 1, 
                Message = "Completed"
            };
        }

        public async Task<AnnounceDetailResponse> AnyAsync(AnnounceDetailAnyDataTransfer Model)
        {
            List<AnnounceDetail> announceDetailDataSource = await UnitOfWork.AnnounceDetail.SelectAsync(x => x.Id == Model.Id && x.IsActive == true);
            return new AnnounceDetailResponse
            {
                List = announceDetailDataSource,
                Success = 1,
                Message = "Completed"
            };
        }
    }
}