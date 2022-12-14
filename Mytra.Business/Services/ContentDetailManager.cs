namespace Mytra.Business
{
    using Core;
    using AutoMapper;
    using FluentValidation;
    using System.Threading.Tasks;
    using System.Collections.Generic;

    public class ContentDetailManager : BusinessObject<ContentDetail>, IContentDetailService
    {
        readonly IMapper Mapper;
        readonly IUnitOfWork UnitOfWork;
        readonly IValidator<ContentDetail> Validator;

        public ContentDetailManager(IMapper mapper, IUnitOfWork unitOfWork, IValidator<ContentDetail> validator)
        {
            Mapper = mapper;
            UnitOfWork = unitOfWork;
            Validator = validator;
        }

        public async Task<ContentDetailResponse> InsertAsync(ContentDetailInsertDataTransfer Model)
        {
            ContentDetail contentDetail = Mapper.Map<ContentDetail>(Model);
            contentDetail.Id = Guid.NewGuid();
            contentDetail.RegisterDate = DateTime.Now;
            contentDetail.UpdateDate = DateTime.Now;
            contentDetail.IsActive = true;

            await UnitOfWork.ContentDetail.InsertAsync(contentDetail);
            int result = await UnitOfWork.SaveChangesAsync();

            return new ContentDetailResponse 
            { 
                Single = contentDetail, 
                Success = result  
            };
        }

        public async Task<ContentDetailResponse> UpdateAsync(ContentDetailUpdateDataTransfer Model)
        {
            List<ContentDetail> DataSource = await UnitOfWork.ContentDetail.SelectAsync(x => x.Id == Model.Id);
            ContentDetail contentDetail = Mapper.Map<ContentDetail>(DataSource[0]);
            contentDetail.UpdateDate = DateTime.Now;

            await UnitOfWork.ContentDetail.UpdateAsync(contentDetail);
            int result = await UnitOfWork.SaveChangesAsync();

            return new ContentDetailResponse 
            {
                Single = contentDetail,
                Success = result
            };
        }

        public async Task<ContentDetailResponse> DeleteAsync(ContentDetailDeleteDataTransfer Model)
        {
            throw new NotImplementedException();
        }

        public async Task<ContentDetailResponse> SelectAsync(ContentDetailSelectDataTransfer Model)
        {
            throw new NotImplementedException();
        }

        public async Task<ContentDetailResponse> AnyAsync(ContentDetailAnyDataTransfer Model)
        {
            throw new NotImplementedException();
        }
    }
}