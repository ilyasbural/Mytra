namespace Mytra.Business
{
    using Core;
    using AutoMapper;
    using FluentValidation;

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

        public async Task<Response<Survey>> InsertAsync(SurveyInsertDataTransfer Model)
        {
            Entity = Mapper.Map<Survey>(Model);
            Entity.Id = Guid.NewGuid();
            Entity.RegisterDate = DateTime.Now;
            Entity.UpdateDate = DateTime.Now;
            Entity.IsActive = true;
            Validator.ValidateAndThrow(Entity);

            await UnitOfWork.Survey.InsertAsync(Entity);
            Result = await UnitOfWork.SaveChangesAsync();

            return new Response<Survey>
            {
                Data = Entity,
                Success = Result,
                Message = "Success",
                IsValidationError = false
            };
        }

        public async Task<Response<Survey>> UpdateAsync(SurveyUpdateDataTransfer Model)
        {
            Collection = await UnitOfWork.Survey.SelectAsync(x => x.Id == Model.Id);
            Entity = Mapper.Map<Survey>(Collection[0]);
            Entity.UpdateDate = DateTime.Now;
            Validator.ValidateAndThrow(Entity);

            await UnitOfWork.Survey.UpdateAsync(Entity);
            Result = await UnitOfWork.SaveChangesAsync();

            return new Response<Survey>
            {
                Data = Entity,
                Success = Result,
                Message = "Success",
                IsValidationError = false
            };
        }

        public async Task<Response<Survey>> DeleteAsync(SurveyDeleteDataTransfer Model)
        {
            Collection = await UnitOfWork.Survey.SelectAsync(x => x.Id == Model.Id);
            Entity = Mapper.Map<Survey>(Collection[0]);

            await UnitOfWork.Survey.DeleteAsync(Entity);
            Result = await UnitOfWork.SaveChangesAsync();

            return new Response<Survey>
            {
                Data = Entity,
                Success = Result,
                Message = "Success",
                IsValidationError = false
            };
        }

        public async Task<Response<Survey>> SelectAsync(SurveySelectDataTransfer Model)
        {
            Collection = await UnitOfWork.Survey.SelectAsync(x => x.IsActive == true);
            return new Response<Survey>
            {
                Collection = Collection,
                Success = Result,
                Message = "Success",
                IsValidationError = false
            };
        }

        public async Task<Response<Survey>> AnySelectAsync(SurveyAnyDataTransfer Model)
        {
            Collection = await UnitOfWork.Survey.SelectAsync(x => x.Id == Model.Id && x.IsActive == true);
            return new Response<Survey>
            {
                Collection = Collection,
                Success = Result,
                Message = "Success",
                IsValidationError = false
            };
        }
    }
}