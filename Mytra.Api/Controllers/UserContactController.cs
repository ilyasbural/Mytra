namespace Mytra.Api.Controllers
{
    using Core;
    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    public class UserContactController : ControllerBase
    {
        readonly IUserContactService Service;
        public UserContactController(IUserContactService service)
        {
            Service = service;
        }

        [HttpPost]
        [Route("api/usercontact")]
        public async Task<Response<UserContact>> Create([FromBody] UserContactInsertDataTransfer Model)
        {
            await Service.InsertAsync(Model);
            return new Response<UserContact>
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
        [Route("api/usercontact")]
        public async Task<Response<UserContact>> Update([FromBody] UserContactUpdateDataTransfer Model)
        {
            await Service.UpdateAsync(Model);
            return new Response<UserContact>
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
        [Route("api/usercontact")]
        public async Task<Response<UserContact>> Delete([FromBody] UserContactDeleteDataTransfer Model)
        {
            await Service.DeleteAsync(Model);
            return new Response<UserContact>
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
        [Route("api/usercontact")]
        public async Task<Response<UserContact>> Get([FromBody] UserContactSelectDataTransfer Model)
        {
            await Service.SelectAsync(Model);
            return new Response<UserContact>
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
        [Route("api/usercontact/{id}")]
        public async Task<Response<UserContact>> Get([FromBody] UserContactAnyDataTransfer Model)
        {
            await Service.AnySelectAsync(Model);
            return new Response<UserContact>
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