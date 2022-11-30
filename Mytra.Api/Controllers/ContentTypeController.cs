namespace Mytra.Api.Controllers
{
    using Core;
    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    public class ContentTypeController : ControllerBase
    {
        private readonly IContentTypeService Service;
        public ContentTypeController(IContentTypeService service)
        {
            Service = service;
        }

        [HttpPost]
        [Route("api/contenttype")]
        public Task<ContentTypeWebResponse> Create([FromBody] ContentTypeInsertDataTransfer Model)
        {
            Task<ContentTypeResponse> Data = Service.AddAsync(Model);
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