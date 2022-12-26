namespace Mytra.Api.Controllers
{
    using Core;
    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    public class PermissionController : ControllerBase
    {
        readonly IPermissionService Service;
        public PermissionController(IPermissionService service)
        {
            Service = service;
        }

        [HttpPost]
        [Route("api/permission")]
        public async Task<Response<Permission>> Create([FromBody] PermissionInsertDataTransfer Model)
        {
            Response<Permission> Response = await Service.InsertAsync(Model);
            return new Response<Permission>
            {
                Data = Response.Data,
                Message = Response.Message,
                Success = Response.Success,
                IsValidationError = Response.IsValidationError
            };
        }

        [HttpPut]
        [Route("api/permission")]
        public async Task<Response<Permission>> Update([FromBody] PermissionUpdateDataTransfer Model)
        {
            Response<Permission> Response = await Service.UpdateAsync(Model);
            return new Response<Permission>
            {
                Data = Response.Data,
                Message = Response.Message,
                Success = Response.Success,
                IsValidationError = Response.IsValidationError
            };
        }

        [HttpDelete]
        [Route("api/permission")]
        public async Task<Response<Permission>> Delete([FromBody] PermissionDeleteDataTransfer Model)
        {
            Response<Permission> Response = await Service.DeleteAsync(Model);
            return new Response<Permission>
            {
                Data = Response.Data,
                Message = Response.Message,
                Success = Response.Success,
                IsValidationError = Response.IsValidationError
            };
        }

        [HttpGet]
        [Route("api/permission")]
        public async Task<Response<Permission>> Get([FromBody] PermissionSelectDataTransfer Model)
        {
            Response<Permission> Response = await Service.SelectAsync(Model);
            return new Response<Permission>
            {
                Collection = Response.Collection,
                Message = Response.Message,
                Success = Response.Success,
                IsValidationError = Response.IsValidationError
            };
        }

        [HttpGet]
        [Route("api/permission/{id}")]
        public async Task<Response<Permission>> Get([FromBody] PermissionAnyDataTransfer Model)
        {
            Response<Permission> Response = await Service.AnySelectAsync(Model);
            return new Response<Permission>
            {
                Collection = Response.Collection,
                Message = Response.Message,
                Success = Response.Success,
                IsValidationError = Response.IsValidationError
            };
        }
    }
}