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
            await Service.InsertAsync(Model);
            return new Response<ContentSettings>
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
        [Route("api/contentsettings")]
        public async Task<Response<ContentSettings>> Update([FromBody] ContentSettingsUpdateDataTransfer Model)
        {
            await Service.UpdateAsync(Model);
            return new Response<ContentSettings>
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
        [Route("api/contentsettings")]
        public async Task<Response<ContentSettings>> Delete([FromBody] ContentSettingsDeleteDataTransfer Model)
        {
            await Service.DeleteAsync(Model);
            return new Response<ContentSettings>
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
        [Route("api/contentsettings")]
        public async Task<Response<ContentSettings>> Get([FromBody] ContentSettingsSelectDataTransfer Model)
        {
            await Service.SelectAsync(Model);
            return new Response<ContentSettings>
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
        [Route("api/contentsettings/{id}")]
        public async Task<Response<ContentSettings>> Get([FromBody] ContentSettingsAnyDataTransfer Model)
        {
            await Service.AnySelectAsync(Model);
            return new Response<ContentSettings>
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