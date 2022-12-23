namespace Mytra.Api.Controllers
{
    using Core;
    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    public class UserController : ControllerBase
    {
        readonly IUserService Service;
        public UserController(IUserService service)
        {
            Service = service;
        }

        [HttpPost]
        [Route("api/user")]
        public async Task<Response<User>> Create([FromBody] UserInsertDataTransfer Model)
        {
            await Service.InsertAsync(Model);
            return new Response<User>
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
        [Route("api/user")]
        public async Task<Response<User>> Update([FromBody] UserUpdateDataTransfer Model)
        {
            await Service.UpdateAsync(Model);
            return new Response<User>
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
        [Route("api/user")]
        public async Task<Response<User>> Delete([FromBody] UserDeleteDataTransfer Model)
        {
            await Service.DeleteAsync(Model);
            return new Response<User>
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
        [Route("api/user")]
        public async Task<Response<User>> Get([FromBody] UserSelectDataTransfer Model)
        {
            await Service.SelectAsync(Model);
            return new Response<User>
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
        [Route("api/user/{id}")]
        public async Task<Response<User>> Get([FromBody] UserAnyDataTransfer Model)
        {
            await Service.AnySelectAsync(Model);
            return new Response<User>
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