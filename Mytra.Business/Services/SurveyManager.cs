namespace Mytra.Business
{
    using Core;
    using AutoMapper;
    using FluentValidation;
    using System.Threading.Tasks;
    using System.Collections.Generic;

    public class SurveyManager : BusinessObject<Survey>, ISurveyService
    {
        readonly IMapper Mapper;
        readonly IUnitOfWork UnitOfWork;
        readonly IValidator<Survey> Validator;

        public SurveyManager(IMapper mapper, IUnitOfWork unitOfWork, IValidator<Survey> validator)
        {
            Mapper = mapper;
            UnitOfWork = unitOfWork;
            Validator = validator;
        }

        public async Task<SurveyResponse> InsertAsync(SurveyInsertDataTransfer Model)
        {
            Survey survey = Mapper.Map<Survey>(Model);
            survey.Id = Guid.NewGuid();
            survey.RegisterDate = DateTime.Now;
            survey.UpdateDate = DateTime.Now;
            survey.IsActive = true;

            await UnitOfWork.Survey.InsertAsync(survey);
            int result = await UnitOfWork.SaveChangesAsync();

            return new SurveyResponse 
            { 
                Single = survey, 
                Success = result ,
                Message = "Completed"
            };
        }

        public async Task<SurveyResponse> UpdateAsync(SurveyUpdateDataTransfer Model)
        {
            List<Survey> DataSource = await UnitOfWork.Survey.SelectAsync(x => x.Id == Model.Id);
            Survey survey = Mapper.Map<Survey>(DataSource[0]);
            survey.UpdateDate = DateTime.Now;

            await UnitOfWork.Survey.UpdateAsync(survey);
            int result = await UnitOfWork.SaveChangesAsync();

            return new SurveyResponse
            {
                Single = survey,
                Success = result,
                Message = "Completed"
            };
        }

        public async Task<SurveyResponse> DeleteAsync(SurveyDeleteDataTransfer Model)
        {
            List<Survey> surveyDataSource = await UnitOfWork.Survey.SelectAsync(x => x.Id == Model.Id);
            Survey survey = Mapper.Map<Survey>(surveyDataSource[0]);

            await UnitOfWork.Survey.DeleteAsync(survey);
            int result = await UnitOfWork.SaveChangesAsync();

            return new SurveyResponse
            {
                Single = survey,
                Success = result,
                Message = "Completed"
            };
        }

        public async Task<SurveyResponse> SelectAsync(SurveySelectDataTransfer Model)
        {
            List<Survey> surveyDataSource = await UnitOfWork.Survey.SelectAsync(x => x.IsActive == true);
            return new SurveyResponse
            {
                List = surveyDataSource,
                Success = 1,
                Message = "Completed"
            };
        }

        public async Task<SurveyResponse> AnyAsync(SurveyAnyDataTransfer Model)
        {
            List<Survey> surveyDataSource = await UnitOfWork.Survey.SelectAsync(x => x.Id == Model.Id && x.IsActive == true);
            return new SurveyResponse
            {
                List = surveyDataSource,
                Success = 1,
                Message = "Completed"
            };
        }
    }
}