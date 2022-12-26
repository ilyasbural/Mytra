namespace Mytra.Api.Controllers
{
    using Core;
    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    public class UserSettingsController : ControllerBase
    {
        readonly IUserSettingsService Service;
        public UserSettingsController(IUserSettingsService service)
        {
            Service = service;
        }

        [HttpPost]
        [Route("api/usersettings")]
        public async Task<Response<UserSettings>> Create([FromBody] UserSettingsInsertDataTransfer Model)
        {
            Response<UserSettings> Response = await Service.InsertAsync(Model);
            return new Response<UserSettings>
            {
                Data = Response.Data,
                Message = Response.Message,
                Success = Response.Success,
                IsValidationError = Response.IsValidationError
            };
        }

        [HttpPut]
        [Route("api/usersettings")]
        public async Task<Response<UserSettings>> Update([FromBody] UserSettingsUpdateDataTransfer Model)
        {
            Response<UserSettings> Response = await Service.UpdateAsync(Model);
            return new Response<UserSettings>
            {
                Data = Response.Data,
                Message = Response.Message,
                Success = Response.Success,
                IsValidationError = Response.IsValidationError
            };
        }

        [HttpDelete]
        [Route("api/usersettings")]
        public async Task<Response<UserSettings>> Delete([FromBody] UserSettingsDeleteDataTransfer Model)
        {
            Response<UserSettings> Response = await Service.DeleteAsync(Model);
            return new Response<UserSettings>
            {
                Data = Response.Data,
                Message = Response.Message,
                Success = Response.Success,
                IsValidationError = Response.IsValidationError
            };
        }

        [HttpGet]
        [Route("api/usersettings")]
        public async Task<Response<UserSettings>> Get([FromBody] UserSettingsSelectDataTransfer Model)
        {
            Response<UserSettings> Response = await Service.SelectAsync(Model);
            return new Response<UserSettings>
            {
                Collection = Response.Collection,
                Message = Response.Message,
                Success = Response.Success,
                IsValidationError = Response.IsValidationError
            };
        }

        [HttpGet]
        [Route("api/usersettings/{id}")]
        public async Task<Response<UserSettings>> Get([FromBody] UserSettingsAnyDataTransfer Model)
        {
            Response<UserSettings> Response = await Service.AnySelectAsync(Model);
            return new Response<UserSettings>
            {
                Collection = Response.Collection,
                Message = Response.Message,
                Success = Response.Success,
                IsValidationError = Response.IsValidationError
            };
        }
    }
}