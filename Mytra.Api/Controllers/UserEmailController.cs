namespace Mytra.Api.Controllers
{
    using Core;
    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    public class UserEmailController : ControllerBase
    {
        readonly IUserEmailService Service;
        public UserEmailController(IUserEmailService service)
        {
            Service = service;
        }

        [HttpPost]
        [Route("api/useremail")]
        public async Task<Response<UserEmail>> Create([FromBody] UserEmailInsertDataTransfer Model)
        {
            await Service.InsertAsync(Model);
            return new Response<UserEmail>
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
        [Route("api/useremail")]
        public async Task<Response<UserEmail>> Update([FromBody] UserEmailUpdateDataTransfer Model)
        {
            await Service.UpdateAsync(Model);
            return new Response<UserEmail>
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
        [Route("api/useremail")]
        public async Task<Response<UserEmail>> Delete([FromBody] UserEmailDeleteDataTransfer Model)
        {
            await Service.DeleteAsync(Model);
            return new Response<UserEmail>
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
        [Route("api/useremail")]
        public async Task<Response<UserEmail>> Get([FromBody] UserEmailSelectDataTransfer Model)
        {
            await Service.SelectAsync(Model);
            return new Response<UserEmail>
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
        [Route("api/useremail/{id}")]
        public async Task<Response<UserEmail>> Get([FromBody] UserEmailAnyDataTransfer Model)
        {
            await Service.AnySelectAsync(Model);
            return new Response<UserEmail>
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