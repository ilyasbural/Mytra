namespace Mytra.Api.Controllers
{
    using Core;
    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    public class ContentLikeController : ControllerBase
    {
        private readonly IContentLikeService Service;
        public ContentLikeController(IContentLikeService service)
        {
            Service = service;
        }

        [HttpPost]
        [Route("api/contentlike")]
        public Task<ContentLikeWebResponse> Create([FromBody] ContentLikeInsertDataTransfer Model)
        {
            Task<ContentLikeResponse> Data = Service.AddAsync(Model);
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