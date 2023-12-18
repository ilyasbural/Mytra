namespace Mytra.Service
{
    using Core;
    using AutoMapper;
    using FluentValidation;

    public partial class AnnounceManager : ServiceObject<Announce>, IAnnounceService
    {
        readonly IMapper Mapper;
        readonly IUnitOfWork UnitOfWork;
        readonly IValidator<Announce> Validator;

        public AnnounceManager(IMapper mapper, IUnitOfWork unitOfWork, IValidator<Announce> validator)
        {
            Mapper = mapper;
            UnitOfWork = unitOfWork;
            Validator = validator;
        }

        public async Task<Response<Announce>> InsertAsync(AnnounceInsertDataTransfer Model)
        {
            Entity = Mapper.Map<Announce>(Model);
            Entity.Id = Guid.NewGuid();
            Entity.RegisterDate = DateTime.Now;
            Entity.UpdateDate = DateTime.Now;
            Entity.IsActive = true;
            Validator.ValidateAndThrow(Entity);

            await UnitOfWork.Announce.InsertAsync(Entity);
            Result = await UnitOfWork.SaveChangesAsync();

            return new Response<Announce>
            {
                Data = Entity,
                Success = Result,
                Message = "Success", 
                IsValidationError = false
            };
        }

        public async Task<Response<Announce>> UpdateAsync(AnnounceUpdateDataTransfer Model)
        {
            Collection = await UnitOfWork.Announce.SelectAsync(x => x.Id == Model.Id);
            Entity = Mapper.Map<Announce>(Collection[0]);
            Entity.UpdateDate = DateTime.Now;
            Validator.ValidateAndThrow(Entity);

            await UnitOfWork.Announce.UpdateAsync(Entity);
            Result = await UnitOfWork.SaveChangesAsync();

            return new Response<Announce>
            {
                Data = Entity,
                Success = Result,
                Message = "Success",
                IsValidationError = false
            };
        }

        public async Task<Response<Announce>> DeleteAsync(AnnounceDeleteDataTransfer Model)
        {
            Collection = await UnitOfWork.Announce.SelectAsync(x => x.Id == Model.Id);
            Entity = Mapper.Map<Announce>(Collection[0]);

            await UnitOfWork.Announce.DeleteAsync(Entity);
            Result = await UnitOfWork.SaveChangesAsync();

            return new Response<Announce>
            {
                Data = Entity,
                Success = Result,
                Message = "Success",
                IsValidationError = false
            };
        }

        public async Task<Response<Announce>> SelectAsync(AnnounceSelectDataTransfer Model)
        {
            Collection = await UnitOfWork.Announce.SelectAsync(x => x.IsActive == true);
            return new Response<Announce>
            {
                Collection = Collection,
                Success = Result,
                Message = "Success",
                IsValidationError = false
            };
        }  

        public async Task<Response<Announce>> AnySelectAsync(AnnounceAnyDataTransfer Model)
        {
            Collection = await UnitOfWork.Announce.SelectAsync(x => x.Id == Model.Id && x.IsActive == true);
            return new Response<Announce>
            {
                Collection = Collection,
                Success = Result,
                Message = "Success",
                IsValidationError = false
            };
        }
    }
}