namespace Mytra.Api.Controllers
{
    using Core;
    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    public class ContentPictureController : ControllerBase
    {
        private readonly IContentPictureService Service;
        public ContentPictureController(IContentPictureService service)
        {
            Service = service;
        }

        [HttpPost]
        [Route("api/contentpicture")]
        public Task<ContentPictureWebResponse> Create([FromBody] ContentPictureInsertDataTransfer Model)
        {
            Task<ContentPictureResponse> Data = Service.AddAsync(Model);
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