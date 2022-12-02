namespace Mytra.Business
{
    using Core;
    using AutoMapper;
    using System.Threading.Tasks;
    using System.Collections.Generic;

    public class SurveyDetailManager : BusinessObject<SurveyDetail>, ISurveyDetailService
    {
        readonly IMapper Mapper;
        readonly IUnitOfWork UnitOfWork;

        public SurveyDetailManager(IMapper mapper, IUnitOfWork unitOfWork)
        {
            Mapper = mapper;
            UnitOfWork = unitOfWork;
        }

        public async Task<SurveyDetailResponse> AddAsync(SurveyDetailInsertDataTransfer Model)
        {
            SurveyDetail surveyDetail = Mapper.Map<SurveyDetail>(Model);
            surveyDetail.Id = Guid.NewGuid();
            surveyDetail.RegisterDate = DateTime.Now;
            surveyDetail.UpdateDate = DateTime.Now;
            surveyDetail.IsActive = true;

            await UnitOfWork.SurveyDetail.AddAsync(surveyDetail);
            await UnitOfWork.SaveChangesAsync();

            return new SurveyDetailResponse
            {
                //Data = Entity,
                //Response = Mapper.Map<AbilityDataTransferInsert>(Entity)
            };
        }

        public async Task<SurveyDetailResponse> UpdateAsync(SurveyDetailUpdateDataTransfer Model)
        {
            throw new NotImplementedException();
        }

        public async Task<SurveyDetailResponse> DeleteAsync(SurveyDetailDeleteDataTransfer Model)
        {
            throw new NotImplementedException();
        }

        public async Task<SurveyDetailResponse> SelectAsync(SurveyDetailSelectDataTransfer Model)
        {
            throw new NotImplementedException();
        }

        public async Task<SurveyDetailResponse> AnyAsync(SurveyDetailAnyDataTransfer Model)
        {
            throw new NotImplementedException();
        }
    }
}