namespace Mytra.Business
{
    using Core;
    using AutoMapper;
    using FluentValidation;

    public class ContentDetailManager : BusinessObject<ContentDetail>, IContentDetailService
    {
        readonly IMapper Mapper;
        readonly IUnitOfWork UnitOfWork;
        readonly IValidator<ContentDetail> Validator;

        public ContentDetailManager(IMapper mapper, IUnitOfWork unitOfWork, IValidator<ContentDetail> validator)
        {
            Mapper = mapper;
            UnitOfWork = unitOfWork;
            Validator = validator;
        }

        public async Task<Response<ContentDetail>> InsertAsync(ContentDetailInsertDataTransfer Model)
        {
            Entity = Mapper.Map<ContentDetail>(Model);
            Entity.Id = Guid.NewGuid();
            Entity.RegisterDate = DateTime.Now;
            Entity.UpdateDate = DateTime.Now;
            Entity.IsActive = true;
            Validator.ValidateAndThrow(Entity);

            await UnitOfWork.ContentDetail.InsertAsync(Entity);
            Result = await UnitOfWork.SaveChangesAsync();

            return new Response<ContentDetail>
            {
                Data = Entity,
                Success = Result,
                Message = "Success",
                IsValidationError = false
            };
        }

        public async Task<Response<ContentDetail>> UpdateAsync(ContentDetailUpdateDataTransfer Model)
        {
            Collection = await UnitOfWork.ContentDetail.SelectAsync(x => x.Id == Model.Id);
            Entity = Mapper.Map<ContentDetail>(Collection[0]);
            Entity.UpdateDate = DateTime.Now;
            Validator.ValidateAndThrow(Entity);

            await UnitOfWork.ContentDetail.UpdateAsync(Entity);
            Result = await UnitOfWork.SaveChangesAsync();

            return new Response<ContentDetail>
            {
                Data = Entity,
                Success = Result,
                Message = "Success",
                IsValidationError = false
            };
        }

        public async Task<Response<ContentDetail>> DeleteAsync(ContentDetailDeleteDataTransfer Model)
        {
            Collection = await UnitOfWork.ContentDetail.SelectAsync(x => x.Id == Model.Id);
            Entity = Mapper.Map<ContentDetail>(Collection[0]);

            await UnitOfWork.ContentDetail.DeleteAsync(Entity);
            Result = await UnitOfWork.SaveChangesAsync();

            return new Response<ContentDetail>
            {
                Data = Entity,
                Success = Result,
                Message = "Success",
                IsValidationError = false
            };
        }

        public async Task<Response<ContentDetail>> SelectAsync(ContentDetailSelectDataTransfer Model)
        {
            Collection = await UnitOfWork.ContentDetail.SelectAsync(x => x.IsActive == true);
            return new Response<ContentDetail>
            {
                Collection = Collection,
                Success = Result,
                Message = "Success",
                IsValidationError = false
            };
        }

        public async Task<Response<ContentDetail>> AnySelectAsync(ContentDetailAnyDataTransfer Model)
        {
            Collection = await UnitOfWork.ContentDetail.SelectAsync(x => x.Id == Model.Id && x.IsActive == true);
            return new Response<ContentDetail>
            {
                Collection = Collection,
                Success = Result,
                Message = "Success",
                IsValidationError = false
            };
        }
    }
}