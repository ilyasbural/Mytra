namespace Mytra.Business
{
    using Core;
    using AutoMapper;
    using System.Threading.Tasks;
    using System.Collections.Generic;

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
    }
}