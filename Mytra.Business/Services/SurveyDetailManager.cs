namespace Mytra.Business
{
    using Core;
    using AutoMapper;
    using FluentValidation;
    using System.Threading.Tasks;
    using System.Collections.Generic;

    public class SurveyDetailManager : BusinessObject<SurveyDetail>, ISurveyDetailService
    {
        readonly IMapper Mapper;
        readonly IUnitOfWork UnitOfWork;
        readonly IValidator<SurveyDetail> Validator;

        public SurveyDetailManager(IMapper mapper, IUnitOfWork unitOfWork, IValidator<SurveyDetail> validator)
        {
            Mapper = mapper;
            UnitOfWork = unitOfWork;
            Validator = validator;
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

            return new SurveyDetailResponse { SurveyDetail = surveyDetail };
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