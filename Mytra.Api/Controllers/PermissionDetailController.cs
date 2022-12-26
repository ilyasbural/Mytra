namespace Mytra.Api.Controllers
{
    using Core;
    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    public class PermissionDetailController : ControllerBase
    {
        readonly IPermissionDetailService Service;
        public PermissionDetailController(IPermissionDetailService service)
        {
            Service = service;
        }

        [HttpPost]
        [Route("api/permissiondetail")]
        public async Task<Response<PermissionDetail>> Create([FromBody] PermissionDetailInsertDataTransfer Model)
        {
            Response<PermissionDetail> Response = await Service.InsertAsync(Model);
            return new Response<PermissionDetail>
            {
                Data = Response.Data,
                Message = Response.Message,
                Success = Response.Success,
                IsValidationError = Response.IsValidationError
            };
        }

        [HttpPut]
        [Route("api/permissiondetail")]
        public async Task<Response<PermissionDetail>> Update([FromBody] PermissionDetailUpdateDataTransfer Model)
        {
            Response<PermissionDetail> Response = await Service.UpdateAsync(Model);
            return new Response<PermissionDetail>
            {
                Data = Response.Data,
                Message = Response.Message,
                Success = Response.Success,
                IsValidationError = Response.IsValidationError
            };
        }

        [HttpDelete]
        [Route("api/permissiondetail")]
        public async Task<Response<PermissionDetail>> Delete([FromBody] PermissionDetailDeleteDataTransfer Model)
        {
            Response<PermissionDetail> Response = await Service.DeleteAsync(Model);
            return new Response<PermissionDetail>
            {
                Data = Response.Data,
                Message = Response.Message,
                Success = Response.Success,
                IsValidationError = Response.IsValidationError
            };
        }

        [HttpGet]
        [Route("api/permissiondetail")]
        public async Task<Response<PermissionDetail>> Get([FromBody] PermissionDetailSelectDataTransfer Model)
        {
            Response<PermissionDetail> Response = await Service.SelectAsync(Model);
            return new Response<PermissionDetail>
            {
                Collection = Response.Collection,
                Message = Response.Message,
                Success = Response.Success,
                IsValidationError = Response.IsValidationError
            };
        }

        [HttpGet]
        [Route("api/permissiondetail/{id}")]
        public async Task<Response<PermissionDetail>> Get([FromBody] PermissionDetailAnyDataTransfer Model)
        {
            Response<PermissionDetail> Response = await Service.AnySelectAsync(Model);
            return new Response<PermissionDetail>
            {
                Collection = Response.Collection,
                Message = Response.Message,
                Success = Response.Success,
                IsValidationError = Response.IsValidationError
            };
        }
    }
}