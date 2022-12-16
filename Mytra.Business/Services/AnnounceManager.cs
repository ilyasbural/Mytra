namespace Mytra.Business
{
    using Core;
    using AutoMapper;
    using FluentValidation;

    public partial class AnnounceManager : BusinessObject<Announce>, IAnnounceService
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

        public async Task<AnnounceResponse> InsertAsync(AnnounceInsertDataTransfer model)
        {
            Announce announce = Mapper.Map<Announce>(model);
            announce.Id = Guid.NewGuid();
            announce.RegisterDate = DateTime.Now;
            announce.UpdateDate = DateTime.Now;
            announce.IsActive = true;

            await UnitOfWork.Announce.InsertAsync(announce);
            int result = await UnitOfWork.SaveChangesAsync();

            return new AnnounceResponse 
            { 
                Single = announce, 
                Success = result, 
                Message = "Completed"
            };
        }

        public async Task<AnnounceResponse> UpdateAsync(AnnounceUpdateDataTransfer Model)
        {
            List<Announce> announceDataSource = await UnitOfWork.Announce.SelectAsync(x => x.Id == Model.Id);
            Announce announce = Mapper.Map<Announce>(announceDataSource[0]);
            announce.UpdateDate = DateTime.Now;

            await UnitOfWork.Announce.UpdateAsync(announce);
            int result = await UnitOfWork.SaveChangesAsync();

            return new AnnounceResponse 
            {
                Single = announce,
                Success = result, 
                Message = "Completed"
            };
        }

        public async Task<AnnounceResponse> DeleteAsync(AnnounceDeleteDataTransfer Model)
        {
            List<Announce> announceDataSource = await UnitOfWork.Announce.SelectAsync(x => x.Id == Model.Id);
            Announce announce = Mapper.Map<Announce>(announceDataSource[0]);

            await UnitOfWork.Announce.DeleteAsync(announce);
            int result = await UnitOfWork.SaveChangesAsync();

            return new AnnounceResponse 
            {
                Single = announce,
                Success = result,
                Message = "Completed"
            };
        }

        public async Task<AnnounceResponse> SelectAsync(AnnounceSelectDataTransfer Model)
        {
            List<Announce> announceDataSource = await UnitOfWork.Announce.SelectAsync(x => x.IsActive == true);
            return new AnnounceResponse 
            {  
                List = announceDataSource, 
                Success = 1, 
                Message = "Completed"
            };
        }  

        public async Task<AnnounceResponse> AnyAsync(AnnounceAnyDataTransfer Model)
        {
            List<Announce> announceDataSource = await UnitOfWork.Announce.SelectAsync(x => x.Id == Model.Id && x.IsActive == true);
            return new AnnounceResponse
            {
                List = announceDataSource,
                Success = 1,
                Message = "Completed"
            };
        }
    }
}