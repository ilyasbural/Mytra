namespace Mytra.Api.Controllers
{
    using Core;
    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    public class ContentTypeController : ControllerBase
    {
        readonly IContentTypeService Service;
        public ContentTypeController(IContentTypeService service)
        {
            Service = service;
        }

        [HttpPost]
        [Route("api/contenttype")]
        public async Task<Response<ContentType>> Create([FromBody] ContentTypeInsertDataTransfer Model)
        {
            Response<ContentType> Response = await Service.InsertAsync(Model);
            return new Response<ContentType>
            {
                Data = Response.Data,
                Message = Response.Message,
                Success = Response.Success,
                IsValidationError = Response.IsValidationError
            };
        }

        [HttpPut]
        [Route("api/contenttype")]
        public async Task<Response<ContentType>> Update([FromBody] ContentTypeUpdateDataTransfer Model)
        {
            Response<ContentType> Response = await Service.UpdateAsync(Model);
            return new Response<ContentType>
            {
                Data = Response.Data,
                Message = Response.Message,
                Success = Response.Success,
                IsValidationError = Response.IsValidationError
            };
        }

        [HttpDelete]
        [Route("api/contenttype")]
        public async Task<Response<ContentType>> Delete([FromBody] ContentTypeDeleteDataTransfer Model)
        {
            Response<ContentType> Response = await Service.DeleteAsync(Model);
            return new Response<ContentType>
            {
                Data = Response.Data,
                Message = Response.Message,
                Success = Response.Success,
                IsValidationError = Response.IsValidationError
            };
        }

        [HttpGet]
        [Route("api/contenttype")]
        public async Task<Response<ContentType>> Get([FromBody] ContentTypeSelectDataTransfer Model)
        {
            Response<ContentType> Response = await Service.SelectAsync(Model);
            return new Response<ContentType>
            {
                Collection = Response.Collection,
                Message = Response.Message,
                Success = Response.Success,
                IsValidationError = Response.IsValidationError
            };
        }

        [HttpGet]
        [Route("api/contenttype/{id}")]
        public async Task<Response<ContentType>> Get([FromBody] ContentTypeAnyDataTransfer Model)
        {
            Response<ContentType> Response = await Service.AnySelectAsync(Model);
            return new Response<ContentType>
            {
                Collection = Response.Collection,
                Message = Response.Message,
                Success = Response.Success,
                IsValidationError = Response.IsValidationError
            };
        }
    }
}