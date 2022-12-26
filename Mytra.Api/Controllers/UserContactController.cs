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
            Response<UserContact> Response = await Service.InsertAsync(Model);
            return new Response<UserContact>
            {
                Data = Response.Data,
                Message = Response.Message,
                Success = Response.Success,
                IsValidationError = Response.IsValidationError
            };
        }

        [HttpPut]
        [Route("api/usercontact")]
        public async Task<Response<UserContact>> Update([FromBody] UserContactUpdateDataTransfer Model)
        {
            Response<UserContact> Response = await Service.UpdateAsync(Model);
            return new Response<UserContact>
            {
                Data = Response.Data,
                Message = Response.Message,
                Success = Response.Success,
                IsValidationError = Response.IsValidationError
            };
        }

        [HttpDelete]
        [Route("api/usercontact")]
        public async Task<Response<UserContact>> Delete([FromBody] UserContactDeleteDataTransfer Model)
        {
            Response<UserContact> Response = await Service.DeleteAsync(Model);
            return new Response<UserContact>
            {
                Data = Response.Data,
                Message = Response.Message,
                Success = Response.Success,
                IsValidationError = Response.IsValidationError
            };
        }

        [HttpGet]
        [Route("api/usercontact")]
        public async Task<Response<UserContact>> Get([FromBody] UserContactSelectDataTransfer Model)
        {
            Response<UserContact> Response = await Service.SelectAsync(Model);
            return new Response<UserContact>
            {
                Collection = Response.Collection,
                Message = Response.Message,
                Success = Response.Success,
                IsValidationError = Response.IsValidationError
            };
        }

        [HttpGet]
        [Route("api/usercontact/{id}")]
        public async Task<Response<UserContact>> Get([FromBody] UserContactAnyDataTransfer Model)
        {
            Response<UserContact> Response = await Service.AnySelectAsync(Model);
            return new Response<UserContact>
            {
                Collection = Response.Collection,
                Message = Response.Message,
                Success = Response.Success,
                IsValidationError = Response.IsValidationError
            };
        }
    }
}