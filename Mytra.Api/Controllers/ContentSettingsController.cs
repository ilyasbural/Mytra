namespace Mytra.Api.Controllers
{
    using Core;
    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    public class ContentSettingsController : ControllerBase
    {
        readonly IContentSettingsService Service;
        public ContentSettingsController(IContentSettingsService service)
        {
            Service = service;
        }

        [HttpPost]
        [Route("api/contentsettings")]
        public async Task<Response<ContentSettings>> Create([FromBody] ContentSettingsInsertDataTransfer Model)
        {
            Response<ContentSettings> Response = await Service.InsertAsync(Model);
            return new Response<ContentSettings>
            {
                Data = Response.Data,
                Message = Response.Message,
                Success = Response.Success,
                IsValidationError = Response.IsValidationError
            };
        }

        [HttpPut]
        [Route("api/contentsettings")]
        public async Task<Response<ContentSettings>> Update([FromBody] ContentSettingsUpdateDataTransfer Model)
        {
            Response<ContentSettings> Response = await Service.UpdateAsync(Model);
            return new Response<ContentSettings>
            {
                Data = Response.Data,
                Message = Response.Message,
                Success = Response.Success,
                IsValidationError = Response.IsValidationError
            };
        }

        [HttpDelete]
        [Route("api/contentsettings")]
        public async Task<Response<ContentSettings>> Delete([FromBody] ContentSettingsDeleteDataTransfer Model)
        {
            Response<ContentSettings> Response = await Service.DeleteAsync(Model);
            return new Response<ContentSettings>
            {
                Data = Response.Data,
                Message = Response.Message,
                Success = Response.Success,
                IsValidationError = Response.IsValidationError
            };
        }

        [HttpGet]
        [Route("api/contentsettings")]
        public async Task<Response<ContentSettings>> Get([FromBody] ContentSettingsSelectDataTransfer Model)
        {
            Response<ContentSettings> Response = await Service.SelectAsync(Model);
            return new Response<ContentSettings>
            {
                Collection = Response.Collection,
                Message = Response.Message,
                Success = Response.Success,
                IsValidationError = Response.IsValidationError
            };
        }

        [HttpGet]
        [Route("api/contentsettings/{id}")]
        public async Task<Response<ContentSettings>> Get([FromBody] ContentSettingsAnyDataTransfer Model)
        {
            Response<ContentSettings> Response = await Service.AnySelectAsync(Model);
            return new Response<ContentSettings>
            {
                Collection = Response.Collection,
                Message = Response.Message,
                Success = Response.Success,
                IsValidationError = Response.IsValidationError
            };
        }
    }
}