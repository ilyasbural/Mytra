namespace Mytra.Api.Controllers
{
    using Core;
    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    public class ManagementDetailController : ControllerBase
    {
        readonly IManagementDetailService Service;
        public ManagementDetailController(IManagementDetailService service)
        {
            Service = service;
        }

        [HttpPost]
        [Route("api/managementdetail")]
        public async Task<Response<ManagementDetail>> Create([FromBody] ManagementDetailInsertDataTransfer Model)
        {
            Response<ManagementDetail> Response = await Service.InsertAsync(Model);
            return new Response<ManagementDetail>
            {
                Data = Response.Data,
                Message = Response.Message,
                Success = Response.Success,
                IsValidationError = Response.IsValidationError
            };
        }
        
        [HttpPut]
        [Route("api/managementdetail")]
        public async Task<Response<ManagementDetail>> Update([FromBody] ManagementDetailUpdateDataTransfer Model)
        {
            Response<ManagementDetail> Response = await Service.UpdateAsync(Model);
            return new Response<ManagementDetail>
            {
                Data = Response.Data,
                Message = Response.Message,
                Success = Response.Success,
                IsValidationError = Response.IsValidationError
            };
        }

        [HttpDelete]
        [Route("api/managementdetail")]
        public async Task<Response<ManagementDetail>> Delete([FromBody] ManagementDetailDeleteDataTransfer Model)
        {
            Response<ManagementDetail> Response = await Service.DeleteAsync(Model);
            return new Response<ManagementDetail>
            {
                Data = Response.Data,
                Message = Response.Message,
                Success = Response.Success,
                IsValidationError = Response.IsValidationError
            };
        }

        [HttpGet]
        [Route("api/managementdetail")]
        public async Task<Response<ManagementDetail>> Get([FromBody] ManagementDetailSelectDataTransfer Model)
        {
            Response<ManagementDetail> Response = await Service.SelectAsync(Model);
            return new Response<ManagementDetail>
            {
                Collection = Response.Collection,
                Message = Response.Message,
                Success = Response.Success,
                IsValidationError = Response.IsValidationError
            };
        }

        [HttpGet]
        [Route("api/managementdetail/{id}")]
        public async Task<Response<ManagementDetail>> Get([FromBody] ManagementDetailAnyDataTransfer Model)
        {
            Response<ManagementDetail> Response = await Service.AnySelectAsync(Model);
            return new Response<ManagementDetail>
            {
                Collection = Response.Collection,
                Message = Response.Message,
                Success = Response.Success,
                IsValidationError = Response.IsValidationError
            };
        }
    }
}