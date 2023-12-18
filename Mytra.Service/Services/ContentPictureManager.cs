namespace Mytra.Service
{
    using Core;
    using AutoMapper;
    using FluentValidation;

    public class ContentPictureManager : ServiceObject<ContentPicture>, IContentPictureService
    {
        readonly IMapper Mapper;
        readonly IUnitOfWork UnitOfWork;
        readonly IValidator<ContentPicture> Validator;

        public ContentPictureManager(IMapper mapper, IUnitOfWork unitOfWork, IValidator<ContentPicture> validator)
        {
            Mapper = mapper;
            UnitOfWork = unitOfWork;
            Validator = validator;
        }

        public async Task<Response<ContentPicture>> InsertAsync(ContentPictureInsertDataTransfer Model)
        {
            Entity = Mapper.Map<ContentPicture>(Model);
            Entity.Id = Guid.NewGuid();
            Entity.RegisterDate = DateTime.Now;
            Entity.UpdateDate = DateTime.Now;
            Entity.IsActive = true;
            Validator.ValidateAndThrow(Entity);

            await UnitOfWork.ContentPicture.InsertAsync(Entity);
            Result = await UnitOfWork.SaveChangesAsync();

            return new Response<ContentPicture>
            {
                Data = Entity,
                Success = Result,
                Message = "Success",
                IsValidationError = false
            };
        }

        public async Task<Response<ContentPicture>> UpdateAsync(ContentPictureUpdateDataTransfer Model)
        {
            Collection = await UnitOfWork.ContentPicture.SelectAsync(x => x.Id == Model.Id);
            Entity = Mapper.Map<ContentPicture>(Collection[0]);
            Entity.UpdateDate = DateTime.Now;
            Validator.ValidateAndThrow(Entity);

            await UnitOfWork.ContentPicture.UpdateAsync(Entity);
            Result = await UnitOfWork.SaveChangesAsync();

            return new Response<ContentPicture>
            {
                Data = Entity,
                Success = Result,
                Message = "Success",
                IsValidationError = false
            };
        }

        public async Task<Response<ContentPicture>> DeleteAsync(ContentPictureDeleteDataTransfer Model)
        {
            Collection = await UnitOfWork.ContentPicture.SelectAsync(x => x.Id == Model.Id);
            Entity = Mapper.Map<ContentPicture>(Collection[0]);

            await UnitOfWork.ContentPicture.DeleteAsync(Entity);
            Result = await UnitOfWork.SaveChangesAsync();

            return new Response<ContentPicture>
            {
                Data = Entity,
                Success = Result,
                Message = "Success",
                IsValidationError = false
            };
        }

        public async Task<Response<ContentPicture>> SelectAsync(ContentPictureSelectDataTransfer Model)
        {
            Collection = await UnitOfWork.ContentPicture.SelectAsync(x => x.IsActive == true);
            return new Response<ContentPicture>
            {
                Collection = Collection,
                Success = Result,
                Message = "Success",
                IsValidationError = false
            };
        }

        public async Task<Response<ContentPicture>> AnySelectAsync(ContentPictureAnyDataTransfer Model)
        {
            Collection = await UnitOfWork.ContentPicture.SelectAsync(x => x.Id == Model.Id && x.IsActive == true);
            return new Response<ContentPicture>
            {
                Collection = Collection,
                Success = Result,
                Message = "Success",
                IsValidationError = false
            };
        }
    }
}