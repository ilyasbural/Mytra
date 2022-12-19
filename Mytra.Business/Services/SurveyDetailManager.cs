namespace Mytra.Business
{
    using Core;
    using AutoMapper;
    using FluentValidation;
    using FluentValidation.Results;

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

        public async Task<SurveyDetailResponse> InsertAsync(SurveyDetailInsertDataTransfer Model)
        {
            Entity = Mapper.Map<SurveyDetail>(Model);
            Validations = Validator.Validate(Entity);
            Entity.Id = Guid.NewGuid();
            Entity.RegisterDate = DateTime.Now;
            Entity.UpdateDate = DateTime.Now;
            Entity.IsActive = true;

            









            await UnitOfWork.SurveyDetail.InsertAsync(Entity);
            int result = await UnitOfWork.SaveChangesAsync();

            return new SurveyDetailResponse 
            {
                Single = Entity,
                Success = Success,
                Message = Message,
                Errors = new List<string>(),
                IsValidationError = IsValidationError,
                Validations = new List<ValidationResult> { Validations }
            };
        }

        public async Task<SurveyDetailResponse> UpdateAsync(SurveyDetailUpdateDataTransfer Model)
        {
            List<SurveyDetail> DataSource = await UnitOfWork.SurveyDetail.SelectAsync(x => x.Id == Model.Id);
            SurveyDetail surveyDetail = Mapper.Map<SurveyDetail>(DataSource[0]);
            surveyDetail.UpdateDate = DateTime.Now;













            await UnitOfWork.SurveyDetail.UpdateAsync(surveyDetail);
            int result = await UnitOfWork.SaveChangesAsync();

            return new SurveyDetailResponse
            {
                Single = surveyDetail,
                Success = result,
                Message = "Completed"
            };
        }

        public async Task<SurveyDetailResponse> DeleteAsync(SurveyDetailDeleteDataTransfer Model)
        {
            List<SurveyDetail> announceDataSource = await UnitOfWork.SurveyDetail.SelectAsync(x => x.Id == Model.Id);
            SurveyDetail surveyDetail = Mapper.Map<SurveyDetail>(announceDataSource[0]);











            await UnitOfWork.SurveyDetail.DeleteAsync(surveyDetail);
            int result = await UnitOfWork.SaveChangesAsync();

            return new SurveyDetailResponse
            {
                Single = surveyDetail,
                Success = result,
                Message = "Completed"
            };
        }

        public async Task<SurveyDetailResponse> SelectAsync(SurveyDetailSelectDataTransfer Model)
        {
            List<SurveyDetail> surveyDetailDataSource = await UnitOfWork.SurveyDetail.SelectAsync(x => x.IsActive == true);
            return new SurveyDetailResponse
            {
                List = surveyDetailDataSource,
                Success = 1,
                Message = "Completed"
            };
        }

        public async Task<SurveyDetailResponse> AnyAsync(SurveyDetailAnyDataTransfer Model)
        {
            List<SurveyDetail> surveyDetailDataSource = await UnitOfWork.SurveyDetail.SelectAsync(x => x.Id == Model.Id && x.IsActive == true);
            return new SurveyDetailResponse
            {
                List = surveyDetailDataSource,
                Success = 1,
                Message = "Completed"
            };
        }
    }
}