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
                Success = result 
            };
        }

        public async Task<AnnounceResponse> UpdateAsync(AnnounceUpdateDataTransfer Model)
        {
            List<Announce> DataSource = await UnitOfWork.Announce.SelectAsync(x => x.Id == Model.Id);
            Announce announce = Mapper.Map<Announce>(DataSource[0]);
            announce.UpdateDate = DateTime.Now;

            await UnitOfWork.Announce.UpdateAsync(announce);
            int result = await UnitOfWork.SaveChangesAsync();

            return new AnnounceResponse 
            {
                Single = announce,
                Success = result
            };
        }

        public async Task<AnnounceResponse> DeleteAsync(AnnounceDeleteDataTransfer Model)
        {
            List<Announce> DataSource = await UnitOfWork.Announce.SelectAsync(x => x.Id == Model.Id);
            Announce announce = Mapper.Map<Announce>(DataSource[0]);

            await UnitOfWork.Announce.DeleteAsync(announce);
            await UnitOfWork.SaveChangesAsync();

            AnnounceResponse Response = Mapper.Map<AnnounceResponse>(announce);
            return new AnnounceResponse { };
        }

        public async Task<AnnounceResponse> SelectAsync(AnnounceSelectDataTransfer Model)
        {
            List<Announce> DataSource = await UnitOfWork.Announce.SelectAsync(x => x.IsActive == true);
            List<AnnounceResponse> announceResponses = Mapper.Map<List<AnnounceResponse>>(DataSource);
            return new AnnounceResponse {  };
        }  

        public async Task<AnnounceResponse> AnyAsync(AnnounceAnyDataTransfer Model)
        {
            AnnounceResponse announceResponse = new AnnounceResponse();
            //Response.IsAvailable = await UnitOfWork.Announce.AnyAsync(x => x.Id == Model.Id);
            //Response.Message = "Found";
            //Response.IsSuccess = true;
            return announceResponse;
        }
    }
}