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
            ContentCommentResponse contentCommentResponse = await Service.AddAsync(Model);
            return new ContentCommentWebResponse
            {
                




            };
        }

        [HttpPut]
        [Route("api/contentcomment")]
        public async Task<ContentCommentWebResponse> Update([FromBody] ContentCommentUpdateDataTransfer Model)
        {
            ContentCommentResponse contentCommentResponse = await Service.UpdateAsync(Model);
            return new ContentCommentWebResponse
            {





            };
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
    }
}