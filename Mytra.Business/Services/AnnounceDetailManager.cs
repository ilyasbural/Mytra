namespace Mytra.Business
{
    using Core;
    using AutoMapper;
    using FluentValidation;

    public partial class AnnounceDetailManager : BusinessObject<AnnounceDetail>, IAnnounceDetailService
    {
        readonly IMapper Mapper;
        readonly IUnitOfWork UnitOfWork;
        readonly IValidator<AnnounceDetail> Validator;

        public AnnounceDetailManager(IMapper mapper, IUnitOfWork unitOfWork, IValidator<AnnounceDetail> validator)
        {
            Mapper = mapper;
            UnitOfWork = unitOfWork;
            Validator = validator;
        }

        public async Task<Response<AnnounceDetail>> InsertAsync(AnnounceDetailInsertDataTransfer Model)
        {
            Entity = Mapper.Map<AnnounceDetail>(Model);
            Entity.Id = Guid.NewGuid();
            Entity.RegisterDate = DateTime.Now;
            Entity.UpdateDate = DateTime.Now;
            Entity.IsActive = true;

            await UnitOfWork.AnnounceDetail.InsertAsync(Entity);
            Result = await UnitOfWork.SaveChangesAsync();

            return new Response<AnnounceDetail> 
            {
                Data = Entity,
                Success = Result,
                Message = "Success",
                IsValidationError = false
            };
        }

        public async Task<Response<AnnounceDetail>> UpdateAsync(AnnounceDetailUpdateDataTransfer Model)
        {
            Collection = await UnitOfWork.AnnounceDetail.SelectAsync(x => x.Id == Model.Id);
            AnnounceDetail picture = Mapper.Map<AnnounceDetail>(Collection[0]);
            picture.UpdateDate = DateTime.Now;

            await UnitOfWork.AnnounceDetail.UpdateAsync(picture);
            Result = await UnitOfWork.SaveChangesAsync();

            return new Response<AnnounceDetail>
            {
                Data = Entity,
                Success = Result,
                Message = "Success",
                IsValidationError = false
            };
        }      

        public async Task<Response<AnnounceDetail>> DeleteAsync(AnnounceDetailDeleteDataTransfer Model)
        {
            Collection = await UnitOfWork.AnnounceDetail.SelectAsync(x => x.Id == Model.Id);
            AnnounceDetail announceDetail = Mapper.Map<AnnounceDetail>(Collection[0]);

            await UnitOfWork.AnnounceDetail.DeleteAsync(announceDetail);
            Result = await UnitOfWork.SaveChangesAsync();

            return new Response<AnnounceDetail>
            {
                Data = Entity,
                Success = Result,
                Message = "Success",
                IsValidationError = false
            };
        }  

        public async Task<Response<AnnounceDetail>> SelectAsync(AnnounceDetailSelectDataTransfer Model)
        {
            Collection = await UnitOfWork.AnnounceDetail.SelectAsync(x => x.IsActive == true);
            return new Response<AnnounceDetail>
            {
                Collection = Collection,
                Success = Result,
                Message = "Success",
                IsValidationError = false
            };
        }

        public async Task<Response<AnnounceDetail>> AnyAsync(AnnounceDetailAnyDataTransfer Model)
        {
            Collection = await UnitOfWork.AnnounceDetail.SelectAsync(x => x.Id == Model.Id && x.IsActive == true);
            return new Response<AnnounceDetail>
            {
                Collection = Collection,
                Success = Result,
                Message = "Success",
                IsValidationError = false
            };
        }
    }
}