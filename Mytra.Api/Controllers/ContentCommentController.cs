namespace Mytra.Api.Controllers
{
    using Core;
    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    public class ContentCommentController : ControllerBase
    {
        private readonly IContentCommentService Service;
        public ContentCommentController(IContentCommentService service)
        {
            Service = service;
        }

        [HttpPost]
        [Route("api/contentcomment")]
        public Task<ContentCommentWebResponse> Create([FromBody] ContentCommentInsertDataTransfer Model)
        {
            Task<ContentCommentResponse> Data = Service.AddAsync(Model);
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