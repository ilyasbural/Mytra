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
            Response<User> Response = await Service.InsertAsync(Model);
            return new Response<User>
            {
                Data = Response.Data,
                Message = Response.Message,
                Success = Response.Success,
                IsValidationError = Response.IsValidationError
            };
        }

        [HttpPut]
        [Route("api/user")]
        public async Task<Response<User>> Update([FromBody] UserUpdateDataTransfer Model)
        {
            Response<User> Response = await Service.UpdateAsync(Model);
            return new Response<User>
            {
                Data = Response.Data,
                Message = Response.Message,
                Success = Response.Success,
                IsValidationError = Response.IsValidationError
            };
        }

        [HttpDelete]
        [Route("api/user")]
        public async Task<Response<User>> Delete([FromBody] UserDeleteDataTransfer Model)
        {
            Response<User> Response = await Service.DeleteAsync(Model);
            return new Response<User>
            {
                Data = Response.Data,
                Message = Response.Message,
                Success = Response.Success,
                IsValidationError = Response.IsValidationError
            };
        }

        [HttpGet]
        [Route("api/user")]
        public async Task<Response<User>> Get([FromBody] UserSelectDataTransfer Model)
        {
            Response<User> Response = await Service.SelectAsync(Model);
            return new Response<User>
            {
                Collection = Response.Collection,
                Message = Response.Message,
                Success = Response.Success,
                IsValidationError = Response.IsValidationError
            };
        }

        [HttpGet]
        [Route("api/user/{id}")]
        public async Task<Response<User>> Get([FromBody] UserAnyDataTransfer Model)
        {
            Response<User> Response = await Service.AnySelectAsync(Model);
            return new Response<User>
            {
                Collection = Response.Collection,
                Message = Response.Message,
                Success = Response.Success,
                IsValidationError = Response.IsValidationError
            };
        }
    }
}