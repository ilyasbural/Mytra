namespace Mytra.Api.Controllers
{
    using Core;
    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    public class ManagementController : ControllerBase
    {
        readonly IManagementService Service;
        public ManagementController(IManagementService service)
        {
            Service = service;
        }

        [HttpPost]
        [Route("api/management")]
        public async Task<Response<Management>> Create([FromBody] ManagementInsertDataTransfer Model)
        {
            await Service.InsertAsync(Model);
            return new Response<Management>
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
        [Route("api/management")]
        public async Task<Response<Management>> Update([FromBody] ManagementUpdateDataTransfer Model)
        {
            await Service.UpdateAsync(Model);
            return new Response<Management>
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
        [Route("api/management")]
        public async Task<Response<Management>> Delete([FromBody] ManagementDeleteDataTransfer Model)
        {
            await Service.DeleteAsync(Model);
            return new Response<Management>
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
        [Route("api/management")]
        public async Task<Response<Management>> Get([FromBody] ManagementSelectDataTransfer Model)
        {
            await Service.SelectAsync(Model);
            return new Response<Management>
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
        [Route("api/management/{id}")]
        public async Task<Response<Management>> Get([FromBody] ManagementAnyDataTransfer Model)
        {
            await Service.AnySelectAsync(Model);
            return new Response<Management>
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