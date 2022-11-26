namespace Mytra.Business
{
    using Core;
    using AutoMapper;
    using System.Threading.Tasks;
    using System.Collections.Generic;

    public class ContentPictureManager : IContentPictureService, IDisposable
    {
        protected IMapper Mapper;
        protected IUnitOfWork UnitOfWork;

        public ContentPictureManager(IMapper mapper, IUnitOfWork unitOfWork)
        {
            Mapper = mapper;
            UnitOfWork = unitOfWork;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}