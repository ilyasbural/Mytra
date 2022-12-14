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
        public async Task<ContentCommentWebResponse> Create([FromBody] ContentCommentInsertDataTransfer Model)
        {
            ContentCommentResponse contentCommentResponse = await Service.InsertAsync(Model);
            return new ContentCommentWebResponse { Single = contentCommentResponse.Single };
        }

        [HttpPut]
        [Route("api/contentcomment")]
        public async Task<ContentCommentWebResponse> Update([FromBody] ContentCommentUpdateDataTransfer Model)
        {
            ContentCommentResponse contentCommentResponse = await Service.UpdateAsync(Model);
            return new ContentCommentWebResponse { Single = contentCommentResponse.Single };
        }

        [HttpDelete]
        [Route("api/contentcomment")]
        public async Task<ContentCommentWebResponse> Delete([FromBody] ContentCommentDeleteDataTransfer Model)
        {
            ContentCommentResponse contentCommentResponse = await Service.DeleteAsync(Model);
            return new ContentCommentWebResponse
            {





            };
        }

        [HttpGet]
        [Route("api/contentcomment")]
        public async Task<ContentCommentWebResponse> Get([FromBody] ContentCommentSelectDataTransfer Model)
        {
            ContentCommentResponse contentCommentResponse = await Service.SelectAsync(Model);
            return new ContentCommentWebResponse
            {





            };
        }

        [HttpGet]
        [Route("api/contentcomment/{id}")]
        public async Task<ContentCommentWebResponse> Get([FromBody] ContentCommentAnyDataTransfer Model)
        {
            ContentCommentResponse contentCommentResponse = await Service.AnyAsync(Model);
            return new ContentCommentWebResponse
            {





            };
        }
    }
}