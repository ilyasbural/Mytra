namespace Mytra.Business
{
    using Core;
    using AutoMapper;
    using System.Threading.Tasks;
    using System.Collections.Generic;

    public class CategoryManager : BusinessObject<Category>, ICategoryService
    {
        readonly IMapper Mapper;
        readonly IUnitOfWork UnitOfWork;

        public CategoryManager(IMapper mapper, IUnitOfWork unitOfWork)
        {
            Mapper = mapper;
            UnitOfWork = unitOfWork;
        }

        public async Task<CategoryResponse> AddAsync(CategoryInsertDataTransfer Model)
        {
            Category Entity = Mapper.Map<Category>(Model);
            Entity.Id = Guid.NewGuid();
            Entity.RegisterDate = DateTime.Now;
            Entity.UpdateDate = DateTime.Now;
            Entity.IsActive = true;

            await UnitOfWork.Category.AddAsync(Entity);
            await UnitOfWork.SaveChangesAsync();

            return new CategoryResponse
            {
                //Data = Entity,
                //Response = Mapper.Map<AbilityDataTransferInsert>(Entity)
            };
        }

        public async Task<CategoryResponse> UpdateAsync(CategoryUpdateDataTransfer Model)
        {
            throw new NotImplementedException();
        }

        public async Task<CategoryResponse> DeleteAsync(CategoryDeleteDataTransfer Model)
        {
            throw new NotImplementedException();
        }

        public async Task<CategoryResponse> SelectAsync(CategorySelectDataTransfer Model)
        {
            throw new NotImplementedException();
        }

        public async Task<CategoryResponse> AnyAsync(CategoryAnyDataTransfer Model)
        {
            throw new NotImplementedException();
        }
    }
}