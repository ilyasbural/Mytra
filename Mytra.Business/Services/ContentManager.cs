namespace Mytra.Business
{
    using Core;
    using AutoMapper;
    using System.Threading.Tasks;
    using System.Collections.Generic;

    public class ContentManager : BusinessObject<Content>, IContentService
    {
        readonly IMapper Mapper;
        readonly IUnitOfWork UnitOfWork;

        public ContentManager(IMapper mapper, IUnitOfWork unitOfWork)
        {
            Mapper = mapper;
            UnitOfWork = unitOfWork;
        }

        public async Task<ContentResponse> AddAsync(ContentInsertDataTransfer Model)
        {
            Content content = Mapper.Map<Content>(Model);
            content.Id = Guid.NewGuid();
            content.RegisterDate = DateTime.Now;
            content.UpdateDate = DateTime.Now;
            content.IsActive = true;

            await UnitOfWork.Content.AddAsync(content);
            await UnitOfWork.SaveChangesAsync();

            return new ContentResponse
            {
                //Data = Entity,
                //Response = Mapper.Map<AbilityDataTransferInsert>(Entity)



            };
        }
    }
}