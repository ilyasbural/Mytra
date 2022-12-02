namespace Mytra.Business
{
    using Core;
    using AutoMapper;
    using System.Threading.Tasks;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class AnnounceManager : BusinessObject<Announce>, IAnnounceService
    {
        readonly IMapper Mapper;
        readonly IUnitOfWork UnitOfWork;

        public AnnounceManager(IMapper mapper, IUnitOfWork unitOfWork)
        {
            Mapper = mapper;
            UnitOfWork = unitOfWork;
        }

        public async Task<AnnounceResponse> AddAsync(AnnounceInsertDataTransfer model)
        {
            Announce announceModel = Mapper.Map<Announce>(model);
            announceModel.Id = Guid.NewGuid();
            announceModel.RegisterDate = DateTime.Now;
            announceModel.UpdateDate = DateTime.Now;
            announceModel.IsActive = true;

            await UnitOfWork.Announce.AddAsync(announceModel);
            await UnitOfWork.SaveChangesAsync();

            return new AnnounceResponse
            {
                //Data = Entity,
                //Response = Mapper.Map<AbilityDataTransferInsert>(Entity)
            };
        }

        public async Task<AnnounceResponse> UpdateAsync(AnnounceUpdateDataTransfer Model)
        {
            List<Announce> DataSource = await UnitOfWork.Announce.SelectAsync(x => x.Id == Model.Id);
            Announce Entity = Mapper.Map<Announce>(DataSource[0]);
            Entity.UpdateDate = DateTime.Now;

            await UnitOfWork.Announce.UpdateAsync(Entity);
            await UnitOfWork.SaveChangesAsync();
            AnnounceResponse Response = Mapper.Map<AnnounceResponse>(Entity);

            return new AnnounceResponse 
            {
                //Data = Entity,
                //Response = Mapper.Map<AbilityDataTransferInsert>(Entity)
            };
        }

        public async Task<AnnounceResponse> DeleteAsync(AnnounceDeleteDataTransfer Model)
        {
            List<Announce> DataSource = await UnitOfWork.Announce.SelectAsync(x => x.Id == Model.Id);
            Announce Entity = Mapper.Map<Announce>(DataSource[0]);
            await UnitOfWork.Announce.DeleteAsync(Entity);
            await UnitOfWork.SaveChangesAsync();
            AnnounceResponse Response = Mapper.Map<AnnounceResponse>(Entity);
            return new AnnounceResponse 
            {
                //Data = Entity,
                //Response = Mapper.Map<AbilityDataTransferInsert>(Entity)
            };
        }

        public async Task<AnnounceResponse> SelectAsync(AnnounceSelectDataTransfer Model)
        {
            List<Announce> DataSource = await UnitOfWork.Announce.SelectAsync(x => x.IsActive == true);
            List<AnnounceResponse> Response = Mapper.Map<List<AnnounceResponse>>(DataSource);
            return new AnnounceResponse { /*Data = DataSource*/ };
        }

        public async Task<AnnounceResponse> AnyAsync(AnnounceAnyDataTransfer Model)
        {
            //Response.IsAvailable = await UnitOfWork.Announce.AnyAsync(x => x.Id == Model.Id);
            //Response.Message = "Found";
            //Response.IsSuccess = true;
            //return Response;

            return new AnnounceResponse
            {
                //Data = Entity,
                //Response = Mapper.Map<AbilityDataTransferInsert>(Entity)
            };
        }
    }
}