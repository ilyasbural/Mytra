namespace Mytra.Business
{
    using Core;
    using AutoMapper;
    using FluentValidation;

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
            Validator.ValidateAndThrow(Entity);

            await UnitOfWork.SurveyDetail.InsertAsync(Entity);
            Result = await UnitOfWork.SaveChangesAsync();

            return new Response<SurveyDetail>
            {
                Data = Entity,
                Success = Result,
                Message = "Success",
                IsValidationError = false
            };
        }

        public async Task<Response<SurveyDetail>> UpdateAsync(SurveyDetailUpdateDataTransfer Model)
        {
            Collection = await UnitOfWork.SurveyDetail.SelectAsync(x => x.Id == Model.Id);
            Entity = Mapper.Map<SurveyDetail>(Collection[0]);
            Entity.UpdateDate = DateTime.Now;
            Validator.ValidateAndThrow(Entity);

            await UnitOfWork.SurveyDetail.UpdateAsync(Entity);
            Result = await UnitOfWork.SaveChangesAsync();

            return new Response<SurveyDetail>
            {
                Data = Entity,
                Success = Result,
                Message = "Success",
                IsValidationError = false
            };
        }

        public async Task<Response<SurveyDetail>> DeleteAsync(SurveyDetailDeleteDataTransfer Model)
        {
            Collection = await UnitOfWork.SurveyDetail.SelectAsync(x => x.Id == Model.Id);
            Entity = Mapper.Map<SurveyDetail>(Collection[0]);

            await UnitOfWork.SurveyDetail.DeleteAsync(Entity);
            Result = await UnitOfWork.SaveChangesAsync();

            return new Response<SurveyDetail>
            {
                Data = Entity,
                Success = Result,
                Message = "Success",
                IsValidationError = false
            };
        }

        public async Task<Response<SurveyDetail>> SelectAsync(SurveyDetailSelectDataTransfer Model)
        {
            Collection = await UnitOfWork.SurveyDetail.SelectAsync(x => x.IsActive == true);
            return new Response<SurveyDetail>
            {
                Collection = Collection,
                Success = Result,
                Message = "Success",
                IsValidationError = false
            };
        }

        public async Task<Response<SurveyDetail>> AnySelectAsync(SurveyDetailAnyDataTransfer Model)
        {
            Collection = await UnitOfWork.SurveyDetail.SelectAsync(x => x.Id == Model.Id && x.IsActive == true);
            return new Response<SurveyDetail>
            {
                Collection = Collection,
                Success = Result,
                Message = "Success",
                IsValidationError = false
            };
        }
    }
}