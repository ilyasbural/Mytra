namespace Mytra.Api.Controllers
{
    using Core;
    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    public class ContentCommentController : ControllerBase
    {
        readonly IContentCommentService Service;
        public ContentCommentController(IContentCommentService service)
        {
            Service = service;
        }

        [HttpPost]
        [Route("api/contentcomment")]
        public async Task<Response<ContentComment>> Create([FromBody] ContentCommentInsertDataTransfer Model)
        {
            Response<ContentComment> Response = await Service.InsertAsync(Model);
            return new Response<ContentComment>
            {
                Data = Response.Data,
                Message = Response.Message,
                Success = Response.Success,
                IsValidationError = Response.IsValidationError
            };
        }

        [HttpPut]
        [Route("api/contentcomment")]
        public async Task<Response<ContentComment>> Update([FromBody] ContentCommentUpdateDataTransfer Model)
        {
            Response<ContentComment> Response = await Service.UpdateAsync(Model);
            return new Response<ContentComment>
            {
                Data = Response.Data,
                Message = Response.Message,
                Success = Response.Success,
                IsValidationError = Response.IsValidationError
            };
        }

        [HttpDelete]
        [Route("api/contentcomment")]
        public async Task<Response<ContentComment>> Delete([FromBody] ContentCommentDeleteDataTransfer Model)
        {
            Response<ContentComment> Response = await Service.DeleteAsync(Model);
            return new Response<ContentComment>
            {
                Data = Response.Data,
                Message = Response.Message,
                Success = Response.Success,
                IsValidationError = Response.IsValidationError
            };
        }

        [HttpGet]
        [Route("api/contentcomment")]
        public async Task<Response<ContentComment>> Get([FromBody] ContentCommentSelectDataTransfer Model)
        {
            Response<ContentComment> Response = await Service.SelectAsync(Model);
            return new Response<ContentComment>
            {
                Collection = Response.Collection,
                Message = Response.Message,
                Success = Response.Success,
                IsValidationError = Response.IsValidationError
            };
        }

        [HttpGet]
        [Route("api/contentcomment/{id}")]
        public async Task<Response<ContentComment>> Get([FromBody] ContentCommentAnyDataTransfer Model)
        {
            Response<ContentComment> Response = await Service.AnySelectAsync(Model);
            return new Response<ContentComment>
            {
                Collection = Response.Collection,
                Message = Response.Message,
                Success = Response.Success,
                IsValidationError = Response.IsValidationError
            };
        }
    }
}