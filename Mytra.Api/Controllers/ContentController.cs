namespace Mytra.Api.Controllers
{
    using Core;
    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    public class ContentController : ControllerBase
    {
        private readonly IContentService Service;
        public ContentController(IContentService service)
        {
            Service = service;
        }

        [HttpPost]
        [Route("api/content")]
        public Task<ContentWebResponse> Create([FromBody] ContentInsertDataTransfer Model)
        {
            Task<ContentResponse> Data = Service.AddAsync(Model);
            //AnnounceResult Result = Service.AddAsync(Model);
            //return new AnnounceResponse
            //{
            //    Id = Result.Id,
            //    Company = Result.Company,
            //    Occupation = Result.Occupation,
            //    Title = Result.Title,
            //    AnnounceDate = Result.AnnounceDate,
            //    CreatedByUser = Result.CreatedByUser,
            //    UpdatedByUser = Result.UpdatedByUser,
            //    RegisterDate = Result.RegisterDate,
            //    UpdateDate = Result.UpdateDate
            //};
            return Create(Model);
        }
    }
}