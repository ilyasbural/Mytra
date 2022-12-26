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
            Response<ManagementContact> Response = await Service.InsertAsync(Model);
            return new Response<ManagementContact>
            {
                Data = Response.Data,
                Message = Response.Message,
                Success = Response.Success,
                IsValidationError = Response.IsValidationError
            };
        }

        [HttpPut]
        [Route("api/managementcontact")]
        public async Task<Response<ManagementContact>> Update([FromBody] ManagementContactUpdateDataTransfer Model)
        {
            Response<ManagementContact> Response = await Service.UpdateAsync(Model);
            return new Response<ManagementContact>
            {
                Data = Response.Data,
                Message = Response.Message,
                Success = Response.Success,
                IsValidationError = Response.IsValidationError
            };
        }

        [HttpDelete]
        [Route("api/managementcontact")]
        public async Task<Response<ManagementContact>> Delete([FromBody] ManagementContactDeleteDataTransfer Model)
        {
            Response<ManagementContact> Response = await Service.DeleteAsync(Model);
            return new Response<ManagementContact>
            {
                Data = Response.Data,
                Message = Response.Message,
                Success = Response.Success,
                IsValidationError = Response.IsValidationError
            };
        }

        [HttpGet]
        [Route("api/managementcontact")]
        public async Task<Response<ManagementContact>> Get([FromBody] ManagementContactSelectDataTransfer Model)
        {
            Response<ManagementContact> Response = await Service.SelectAsync(Model);
            return new Response<ManagementContact>
            {
                Collection = Response.Collection,
                Message = Response.Message,
                Success = Response.Success,
                IsValidationError = Response.IsValidationError
            };
        }

        [HttpGet]
        [Route("api/managementcontact/{id}")]
        public async Task<Response<ManagementContact>> Get([FromBody] ManagementContactAnyDataTransfer Model)
        {
            Response<ManagementContact> Response = await Service.AnySelectAsync(Model);
            return new Response<ManagementContact>
            {
                Collection = Response.Collection,
                Message = Response.Message,
                Success = Response.Success,
                IsValidationError = Response.IsValidationError
            };
        }
    }
}