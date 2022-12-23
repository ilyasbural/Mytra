namespace Mytra.Api.Controllers
{
    using Core;
    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    public class ManagementContactController : ControllerBase
    {
        readonly IManagementContactService Service;
        public ManagementContactController(IManagementContactService service)
        {
            Service = service;
        }

        [HttpPost]
        [Route("api/managementcontact")]
        public async Task<Response<ManagementContact>> Create([FromBody] ManagementContactInsertDataTransfer Model)
        {
            await Service.InsertAsync(Model);
            return new Response<ManagementContact>
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
        [Route("api/managementcontact")]
        public async Task<Response<ManagementContact>> Get([FromBody] ManagementContactSelectDataTransfer Model)
        {
            await Service.SelectAsync(Model);
            return new Response<ManagementContact>
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
        [Route("api/managementcontact/{id}")]
        public async Task<Response<ManagementContact>> Get([FromBody] ManagementContactAnyDataTransfer Model)
        {
            await Service.AnySelectAsync(Model);
            return new Response<ManagementContact>
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