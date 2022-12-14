namespace Mytra.Api.Controllers
{
    using Core;
    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    public class PermissionDetailController : ControllerBase
    {
        private readonly IPermissionDetailService Service;
        public PermissionDetailController(IPermissionDetailService service)
        {
            Service = service;
        }

        [HttpPost]
        [Route("api/permissiondetail")]
        public async Task<PermissionDetailWebResponse> Create([FromBody] PermissionDetailInsertDataTransfer Model)
        {
            PermissionDetailResponse permissionDetailResponse = await Service.InsertAsync(Model);
            return new PermissionDetailWebResponse { Single = permissionDetailResponse.Single };
        }

        [HttpPut]
        [Route("api/permissiondetail")]
        public async Task<PermissionDetailWebResponse> Update([FromBody] PermissionDetailUpdateDataTransfer Model)
        {
            PermissionDetailResponse permissionDetailResponse = await Service.UpdateAsync(Model);
            return new PermissionDetailWebResponse { Single = permissionDetailResponse.Single };
        }

        [HttpDelete]
        [Route("api/permissiondetail")]
        public async Task<PermissionDetailWebResponse> Delete([FromBody] PermissionDetailDeleteDataTransfer Model)
        {
            PermissionDetailResponse permissionDetailResponse = await Service.DeleteAsync(Model);
            return new PermissionDetailWebResponse
            {


            };
        }

        [HttpGet]
        [Route("api/permissiondetail")]
        public async Task<PermissionDetailWebResponse> Get([FromBody] PermissionDetailSelectDataTransfer Model)
        {
            PermissionDetailResponse permissionDetailResponse = await Service.SelectAsync(Model);
            return new PermissionDetailWebResponse
            {


            };
        }

        [HttpGet]
        [Route("api/permissiondetail/{id}")]
        public async Task<PermissionDetailWebResponse> Get([FromBody] PermissionDetailAnyDataTransfer Model)
        {
            PermissionDetailResponse permissionDetailResponse = await Service.AnyAsync(Model);
            return new PermissionDetailWebResponse
            {


            };
        }
    }
}