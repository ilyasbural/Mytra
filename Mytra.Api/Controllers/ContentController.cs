namespace Mytra.Api.Controllers
{
    using Core;
    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    public class ContentController : ControllerBase
    {
        readonly IContentService Service;
        public ContentController(IContentService service)
        {
            Service = service;
        }

        [HttpPost]
        [Route("api/content")]
        public async Task<Response<Content>> Create([FromBody] ContentInsertDataTransfer Model)
        {
            Response<Content> Response = await Service.InsertAsync(Model);
            return new Response<Content>
            {
                Data = Response.Data,
                Message = Response.Message,
                Success = Response.Success,
                IsValidationError = Response.IsValidationError
            };
        }

        [HttpPut]
        [Route("api/content")]
        public async Task<Response<Content>> Update([FromBody] ContentUpdateDataTransfer Model)
        {
            Response<Content> Response = await Service.UpdateAsync(Model);
            return new Response<Content>
            {
                Data = Response.Data,
                Message = Response.Message,
                Success = Response.Success,
                IsValidationError = Response.IsValidationError
            };
        }

        [HttpDelete]
        [Route("api/content")]
        public async Task<Response<Content>> Delete([FromBody] ContentDeleteDataTransfer Model)
        {
            Response<Content> Response = await Service.DeleteAsync(Model);
            return new Response<Content>
            {
                Data = Response.Data,
                Message = Response.Message,
                Success = Response.Success,
                IsValidationError = Response.IsValidationError
            };
        }

        [HttpGet]
        [Route("api/content")]
        public async Task<Response<Content>> Get([FromBody] ContentSelectDataTransfer Model)
        {
            Response<Content> Response = await Service.SelectAsync(Model);
            return new Response<Content>
            {
                Collection = Response.Collection,
                Message = Response.Message,
                Success = Response.Success,
                IsValidationError = Response.IsValidationError
            };
        }

        [HttpGet]
        [Route("api/content/{id}")]
        public async Task<Response<Content>> Get([FromBody] ContentAnyDataTransfer Model)
        {
            Response<Content> Response = await Service.AnySelectAsync(Model);
            return new Response<Content>
            {
                Collection = Response.Collection,
                Message = Response.Message,
                Success = Response.Success,
                IsValidationError = Response.IsValidationError
            };
        }
    }
}