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
            await Service.InsertAsync(Model);
            return new Response<UserSettings>
            {
                //Single = Response.Entity,
                //Success = Success,
                //Message = Message,
                //Errors = new List<string>(),
                //IsValidationError = IsValidationError,
                //Validations = new List<ValidationResult> { Validations }
            };
        }

        [HttpPut]
        [Route("api/usersettings")]
        public async Task<Response<UserSettings>> Update([FromBody] UserSettingsUpdateDataTransfer Model)
        {
            await Service.UpdateAsync(Model);
            return new Response<UserSettings>
            {
                //Single = Response.Entity,
                //Success = Success,
                //Message = Message,
                //Errors = new List<string>(),
                //IsValidationError = IsValidationError,
                //Validations = new List<ValidationResult> { Validations }
            };
        }

        [HttpDelete]
        [Route("api/usersettings")]
        public async Task<Response<UserSettings>> Delete([FromBody] UserSettingsDeleteDataTransfer Model)
        {
            await Service.DeleteAsync(Model);
            return new Response<UserSettings>
            {
                //Single = Response.Entity,
                //Success = Success,
                //Message = Message,
                //Errors = new List<string>(),
                //IsValidationError = IsValidationError,
                //Validations = new List<ValidationResult> { Validations }
            };
        }

        [HttpGet]
        [Route("api/usersettings")]
        public async Task<Response<UserSettings>> Get([FromBody] UserSettingsSelectDataTransfer Model)
        {
            await Service.SelectAsync(Model);
            return new Response<UserSettings>
            {
                //Single = Response.Entity,
                //Success = Success,
                //Message = Message,
                //Errors = new List<string>(),
                //IsValidationError = IsValidationError,
                //Validations = new List<ValidationResult> { Validations }
            };
        }

        [HttpGet]
        [Route("api/usersettings/{id}")]
        public async Task<Response<UserSettings>> Get([FromBody] UserSettingsAnyDataTransfer Model)
        {
            await Service.AnySelectAsync(Model);
            return new Response<UserSettings>
            {
                //Single = Response.Entity,
                //Success = Success,
                //Message = Message,
                //Errors = new List<string>(),
                //IsValidationError = IsValidationError,
                //Validations = new List<ValidationResult> { Validations }
            };
        }
    }
}