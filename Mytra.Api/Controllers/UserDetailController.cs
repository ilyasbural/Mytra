namespace Mytra.Api.Controllers
{
    using Core;
    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    public class UserDetailController : ControllerBase
    {
        readonly IUserDetailService Service;
        public UserDetailController(IUserDetailService service)
        {
            Service = service;
        }

        [HttpPost]
        [Route("api/userdetail")]
        public async Task<Response<UserDetail>> Create([FromBody] UserDetailInsertDataTransfer Model)
        {
            await Service.InsertAsync(Model);
            return new Response<UserDetail>
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
        [Route("api/userdetail")]
        public async Task<Response<UserDetail>> Update([FromBody] UserDetailUpdateDataTransfer Model)
        {
            await Service.UpdateAsync(Model);
            return new Response<UserDetail>
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
        [Route("api/userdetail")]
        public async Task<Response<UserDetail>> Delete([FromBody] UserDetailDeleteDataTransfer Model)
        {
            await Service.DeleteAsync(Model);
            return new Response<UserDetail>
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
        [Route("api/userdetail")]
        public async Task<Response<UserDetail>> Get([FromBody] UserDetailSelectDataTransfer Model)
        {
            await Service.SelectAsync(Model);
            return new Response<UserDetail>
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
        [Route("api/userdetail/{id}")]
        public async Task<Response<UserDetail>> Get([FromBody] UserDetailAnyDataTransfer Model)
        {
            await Service.AnySelectAsync(Model);
            return new Response<UserDetail>
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