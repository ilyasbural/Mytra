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
            await Service.InsertAsync(Model);
            return new Response<ManagementSettings>
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
        [Route("api/managementsettings")]
        public async Task<Response<ManagementSettings>> Update([FromBody] ManagementSettingsUpdateDataTransfer Model)
        {
            await Service.UpdateAsync(Model);
            return new Response<ManagementSettings>
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
        [Route("api/managementsettings")]
        public async Task<Response<ManagementSettings>> Delete([FromBody] ManagementSettingsDeleteDataTransfer Model)
        {
            await Service.DeleteAsync(Model);
            return new Response<ManagementSettings>
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
        [Route("api/managementsettings")]
        public async Task<Response<ManagementSettings>> Get([FromBody] ManagementSettingsSelectDataTransfer Model)
        {
            await Service.SelectAsync(Model);
            return new Response<ManagementSettings>
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
        [Route("api/managementsettings/{id}")]
        public async Task<Response<ManagementSettings>> Get([FromBody] ManagementSettingsAnyDataTransfer Model)
        {
            await Service.AnySelectAsync(Model);
            return new Response<ManagementSettings>
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