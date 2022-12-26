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
            Response<UserEmail> Response = await Service.InsertAsync(Model);
            return new Response<UserEmail>
            {
                Data = Response.Data,
                Message = Response.Message,
                Success = Response.Success,
                IsValidationError = Response.IsValidationError
            };
        }

        [HttpPut]
        [Route("api/useremail")]
        public async Task<Response<UserEmail>> Update([FromBody] UserEmailUpdateDataTransfer Model)
        {
            Response<UserEmail> Response = await Service.UpdateAsync(Model);
            return new Response<UserEmail>
            {
                Data = Response.Data,
                Message = Response.Message,
                Success = Response.Success,
                IsValidationError = Response.IsValidationError
            };
        }

        [HttpDelete]
        [Route("api/useremail")]
        public async Task<Response<UserEmail>> Delete([FromBody] UserEmailDeleteDataTransfer Model)
        {
            Response<UserEmail> Response = await Service.DeleteAsync(Model);
            return new Response<UserEmail>
            {
                Data = Response.Data,
                Message = Response.Message,
                Success = Response.Success,
                IsValidationError = Response.IsValidationError
            };
        }

        [HttpGet]
        [Route("api/useremail")]
        public async Task<Response<UserEmail>> Get([FromBody] UserEmailSelectDataTransfer Model)
        {
            Response<UserEmail> Response = await Service.SelectAsync(Model);
            return new Response<UserEmail>
            {
                Collection = Response.Collection,
                Message = Response.Message,
                Success = Response.Success,
                IsValidationError = Response.IsValidationError
            };
        }

        [HttpGet]
        [Route("api/useremail/{id}")]
        public async Task<Response<UserEmail>> Get([FromBody] UserEmailAnyDataTransfer Model)
        {
            Response<UserEmail> Response = await Service.AnySelectAsync(Model);
            return new Response<UserEmail>
            {
                Collection = Response.Collection,
                Message = Response.Message,
                Success = Response.Success,
                IsValidationError = Response.IsValidationError
            };
        }
    }
}