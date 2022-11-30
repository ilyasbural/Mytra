namespace Mytra.Api.Controllers
{
    using Core;
    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    public class ContentDetailController : ControllerBase
    {
        private readonly IContentDetailService Service;
        public ContentDetailController(IContentDetailService service)
        {
            Service = service;
        }

        [HttpPost]
        [Route("api/contentdetail")]
        public Task<ContentDetailWebResponse> Create([FromBody] ContentDetailInsertDataTransfer Model)
        {
            Task<ContentDetailResponse> Data = Service.AddAsync(Model);
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