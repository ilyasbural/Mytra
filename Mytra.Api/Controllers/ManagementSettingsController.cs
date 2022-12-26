namespace Mytra.Api.Controllers
{
    using Core;
    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    public class ManagementSettingsController : ControllerBase
    {
        readonly IManagementSettingsService Service;
        public ManagementSettingsController(IManagementSettingsService service)
        {
            Service = service;
        }

        [HttpPost]
        [Route("api/managementsettings")]
        public async Task<Response<ManagementSettings>> Create([FromBody] ManagementSettingsInsertDataTransfer Model)
        {
            Response<ManagementSettings> Response = await Service.InsertAsync(Model);
            return new Response<ManagementSettings>
            {
                Data = Response.Data,
                Message = Response.Message,
                Success = Response.Success,
                IsValidationError = Response.IsValidationError
            };
        }

        [HttpPut]
        [Route("api/managementsettings")]
        public async Task<Response<ManagementSettings>> Update([FromBody] ManagementSettingsUpdateDataTransfer Model)
        {
            Response<ManagementSettings> Response = await Service.UpdateAsync(Model);
            return new Response<ManagementSettings>
            {
                Data = Response.Data,
                Message = Response.Message,
                Success = Response.Success,
                IsValidationError = Response.IsValidationError
            };
        }

        [HttpDelete]
        [Route("api/managementsettings")]
        public async Task<Response<ManagementSettings>> Delete([FromBody] ManagementSettingsDeleteDataTransfer Model)
        {
            Response<ManagementSettings> Response = await Service.DeleteAsync(Model);
            return new Response<ManagementSettings>
            {
                Data = Response.Data,
                Message = Response.Message,
                Success = Response.Success,
                IsValidationError = Response.IsValidationError
            };
        }

        [HttpGet]
        [Route("api/managementsettings")]
        public async Task<Response<ManagementSettings>> Get([FromBody] ManagementSettingsSelectDataTransfer Model)
        {
            Response<ManagementSettings> Response = await Service.SelectAsync(Model);
            return new Response<ManagementSettings>
            {
                Collection = Response.Collection,
                Message = Response.Message,
                Success = Response.Success,
                IsValidationError = Response.IsValidationError
            };
        }

        [HttpGet]
        [Route("api/managementsettings/{id}")]
        public async Task<Response<ManagementSettings>> Get([FromBody] ManagementSettingsAnyDataTransfer Model)
        {
            Response<ManagementSettings> Response = await Service.AnySelectAsync(Model);
            return new Response<ManagementSettings>
            {
                Collection = Response.Collection,
                Message = Response.Message,
                Success = Response.Success,
                IsValidationError = Response.IsValidationError
            };
        }
    }
}