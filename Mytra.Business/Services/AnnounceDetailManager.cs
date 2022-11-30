namespace Mytra.Business
{
    using Core;
    using AutoMapper;
    using System.Threading.Tasks;
    using System.Collections.Generic;

    public class AnnounceDetailManager : IAnnounceDetailService
    {
        readonly IMapper Mapper;
        readonly IUnitOfWork UnitOfWork;

        public AnnounceDetailManager(IMapper mapper, IUnitOfWork unitOfWork)
        {
            Mapper = mapper;
            UnitOfWork = unitOfWork;
        }

        public async Task<AnnounceDetailResponse> AddAsync(AnnounceDetailInsertDataTransfer Model)
        {
            //AnnounceDetail announceDetail = Mapper.Map<AnnounceDetail>(Model);
            AnnounceDetail announceDetail = new AnnounceDetail();
            announceDetail.Id = Guid.NewGuid();
            announceDetail.Announce = new Guid("8261DB74-2C06-4C1B-92EF-7A9BE63B5A5E");
            announceDetail.Detail = "dsfsdf";
            announceDetail.RegisterDate = DateTime.Now;
            announceDetail.UpdateDate = DateTime.Now;
            announceDetail.IsActive = true;

            await UnitOfWork.AnnounceDetail.AddAsync(announceDetail);
            await UnitOfWork.SaveChangesAsync();

            return new AnnounceDetailResponse
            {
                //Data = Entity,
                //Response = Mapper.Map<AbilityDataTransferInsert>(Entity)






            };
        }
    }
}