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
            Response<UserDetail> Response = await Service.InsertAsync(Model);
            return new Response<UserDetail>
            {
                Data = Response.Data,
                Message = Response.Message,
                Success = Response.Success,
                IsValidationError = Response.IsValidationError
            };
        }

        [HttpPut]
        [Route("api/userdetail")]
        public async Task<Response<UserDetail>> Update([FromBody] UserDetailUpdateDataTransfer Model)
        {
            Response<UserDetail> Response = await Service.UpdateAsync(Model);
            return new Response<UserDetail>
            {
                Data = Response.Data,
                Message = Response.Message,
                Success = Response.Success,
                IsValidationError = Response.IsValidationError
            };
        }

        [HttpDelete]
        [Route("api/userdetail")]
        public async Task<Response<UserDetail>> Delete([FromBody] UserDetailDeleteDataTransfer Model)
        {
            Response<UserDetail> Response = await Service.DeleteAsync(Model);
            return new Response<UserDetail>
            {
                Data = Response.Data,
                Message = Response.Message,
                Success = Response.Success,
                IsValidationError = Response.IsValidationError
            };
        }

        [HttpGet]
        [Route("api/userdetail")]
        public async Task<Response<UserDetail>> Get([FromBody] UserDetailSelectDataTransfer Model)
        {
            Response<UserDetail> Response = await Service.SelectAsync(Model);
            return new Response<UserDetail>
            {
                Collection = Response.Collection,
                Message = Response.Message,
                Success = Response.Success,
                IsValidationError = Response.IsValidationError
            };
        }

        [HttpGet]
        [Route("api/userdetail/{id}")]
        public async Task<Response<UserDetail>> Get([FromBody] UserDetailAnyDataTransfer Model)
        {
            Response<UserDetail> Response = await Service.AnySelectAsync(Model);
            return new Response<UserDetail>
            {
                Collection = Response.Collection,
                Message = Response.Message,
                Success = Response.Success,
                IsValidationError = Response.IsValidationError
            };
        }
    }
}