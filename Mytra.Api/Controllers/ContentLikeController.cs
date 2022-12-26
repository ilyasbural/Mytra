namespace Mytra.Api.Controllers
{
    using Core;
    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    public class ContentLikeController : ControllerBase
    {
        readonly IContentLikeService Service;
        public ContentLikeController(IContentLikeService service)
        {
            Service = service;
        }

        [HttpPost]
        [Route("api/contentlike")]
        public async Task<Response<ContentLike>> Create([FromBody] ContentLikeInsertDataTransfer Model)
        {
            Response<ContentLike> Response = await Service.InsertAsync(Model);
            return new Response<ContentLike>
            {
                Data = Response.Data,
                Message = Response.Message,
                Success = Response.Success,
                IsValidationError = Response.IsValidationError
            };
        }

        [HttpPut]
        [Route("api/contentlike")]
        public async Task<Response<ContentLike>> Update([FromBody] ContentLikeUpdateDataTransfer Model)
        {
            Response<ContentLike> Response = await Service.UpdateAsync(Model);
            return new Response<ContentLike>
            {
                Data = Response.Data,
                Message = Response.Message,
                Success = Response.Success,
                IsValidationError = Response.IsValidationError
            };
        }

        [HttpDelete]
        [Route("api/contentlike")]
        public async Task<Response<ContentLike>> Delete([FromBody] ContentLikeDeleteDataTransfer Model)
        {
            Response<ContentLike> Response = await Service.DeleteAsync(Model);
            return new Response<ContentLike>
            {
                Data = Response.Data,
                Message = Response.Message,
                Success = Response.Success,
                IsValidationError = Response.IsValidationError
            };
        }

        [HttpGet]
        [Route("api/contentlike")]
        public async Task<Response<ContentLike>> Get([FromBody] ContentLikeSelectDataTransfer Model)
        {
            Response<ContentLike> Response = await Service.SelectAsync(Model);
            return new Response<ContentLike>
            {
                Collection = Response.Collection,
                Message = Response.Message,
                Success = Response.Success,
                IsValidationError = Response.IsValidationError
            };
        }

        [HttpGet]
        [Route("api/contentlike/{id}")]
        public async Task<Response<ContentLike>> Get([FromBody] ContentLikeAnyDataTransfer Model)
        {
            Response<ContentLike> Response = await Service.AnySelectAsync(Model);
            return new Response<ContentLike>
            {
                Collection = Response.Collection,
                Message = Response.Message,
                Success = Response.Success,
                IsValidationError = Response.IsValidationError
            };
        }
    }
}