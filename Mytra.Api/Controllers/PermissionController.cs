namespace Mytra.Api.Controllers
{
    using Core;
    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    public class PermissionController : ControllerBase
    {
        private readonly IPermissionService Service;
        public PermissionController(IPermissionService service)
        {
            Service = service;
        }

        [HttpPost]
        [Route("api/permission")]
        public async Task<PermissionWebResponse> Create([FromBody] PermissionInsertDataTransfer Model)
        {
            PermissionResponse permissionResponse = await Service.AddAsync(Model);
            return new PermissionWebResponse { Permission = permissionResponse.Permission };
        }

        [HttpPut]
        [Route("api/permission")]
        public async Task<PermissionWebResponse> Update([FromBody] PermissionUpdateDataTransfer Model)
        {
            PermissionResponse permissionResponse = await Service.UpdateAsync(Model);
            return new PermissionWebResponse
            {


            };
        }

        [HttpDelete]
        [Route("api/permission")]
        public async Task<PermissionWebResponse> Delete([FromBody] PermissionDeleteDataTransfer Model)
        {
            PermissionResponse permissionResponse = await Service.DeleteAsync(Model);
            return new PermissionWebResponse
            {


            };
        }

        [HttpGet]
        [Route("api/permission")]
        public async Task<PermissionWebResponse> Get([FromBody] PermissionSelectDataTransfer Model)
        {
            PermissionResponse permissionResponse = await Service.SelectAsync(Model);
            return new PermissionWebResponse
            {


            };
        }

        [HttpGet]
        [Route("api/permission/{id}")]
        public async Task<PermissionWebResponse> Get([FromBody] PermissionAnyDataTransfer Model)
        {
            PermissionResponse permissionResponse = await Service.AnyAsync(Model);
            return new PermissionWebResponse
            {


            };
        }
    }
}