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

        public async Task<Response<SurveyDetail>> InsertAsync(SurveyDetailInsertDataTransfer Model)
        {
            Entity = Mapper.Map<SurveyDetail>(Model);
            Entity.Id = Guid.NewGuid();
            Entity.RegisterDate = DateTime.Now;
            Entity.UpdateDate = DateTime.Now;
            Entity.IsActive = true;

           



            await UnitOfWork.SurveyDetail.InsertAsync(Entity);
            int result = await UnitOfWork.SaveChangesAsync();

            return new Response<SurveyDetail>
            {
                //Single = Entity,
                //Success = Success,
                //Message = Message,
                //Errors = new List<string>(),
                //IsValidationError = IsValidationError,
                //Validations = new List<ValidationResult> { Validations }
            };
        }

        public async Task<Response<SurveyDetail>> UpdateAsync(SurveyDetailUpdateDataTransfer Model)
        {
            List<SurveyDetail> DataSource = await UnitOfWork.SurveyDetail.SelectAsync(x => x.Id == Model.Id);
            SurveyDetail surveyDetail = Mapper.Map<SurveyDetail>(DataSource[0]);
            surveyDetail.UpdateDate = DateTime.Now;













            await UnitOfWork.SurveyDetail.UpdateAsync(surveyDetail);
            int result = await UnitOfWork.SaveChangesAsync();

            return new Response<SurveyDetail>
            {
                //Single = Entity,
                //Success = Success,
                //Message = Message,
                //Errors = new List<string>(),
                //IsValidationError = IsValidationError,
                //Validations = new List<ValidationResult> { Validations }
            };
        }

        public async Task<Response<SurveyDetail>> DeleteAsync(SurveyDetailDeleteDataTransfer Model)
        {
            List<SurveyDetail> announceDataSource = await UnitOfWork.SurveyDetail.SelectAsync(x => x.Id == Model.Id);
            SurveyDetail surveyDetail = Mapper.Map<SurveyDetail>(announceDataSource[0]);











            await UnitOfWork.SurveyDetail.DeleteAsync(surveyDetail);
            int result = await UnitOfWork.SaveChangesAsync();

            return new Response<SurveyDetail>
            {
                //Single = Entity,
                //Success = Success,
                //Message = Message,
                //Errors = new List<string>(),
                //IsValidationError = IsValidationError,
                //Validations = new List<ValidationResult> { Validations }
            };
        }

        public async Task<Response<SurveyDetail>> SelectAsync(SurveyDetailSelectDataTransfer Model)
        {
            List<SurveyDetail> surveyDetailDataSource = await UnitOfWork.SurveyDetail.SelectAsync(x => x.IsActive == true);
            return new Response<SurveyDetail>
            {
                //Single = Entity,
                //Success = Success,
                //Message = Message,
                //Errors = new List<string>(),
                //IsValidationError = IsValidationError,
                //Validations = new List<ValidationResult> { Validations }
            };
        }

        public async Task<Response<SurveyDetail>> AnySelectAsync(SurveyDetailAnyDataTransfer Model)
        {
            List<SurveyDetail> surveyDetailDataSource = await UnitOfWork.SurveyDetail.SelectAsync(x => x.Id == Model.Id && x.IsActive == true);
            return new Response<SurveyDetail>
            {
                //Single = Entity,
                //Success = Success,
                //Message = Message,
                //Errors = new List<string>(),
                //IsValidationError = IsValidationError,
                //Validations = new List<ValidationResult> { Validations }
            };
        }
    }
}