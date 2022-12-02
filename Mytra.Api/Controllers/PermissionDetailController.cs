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
            PermissionDetailResponse permissionDetailResponse = await Service.AddAsync(Model);
            return new PermissionDetailWebResponse
            {
                

            };
        }

        [HttpPut]
        [Route("api/permissiondetail")]
        public async Task<PermissionDetailWebResponse> Update([FromBody] PermissionDetailUpdateDataTransfer Model)
        {
            PermissionDetailResponse permissionDetailResponse = await Service.UpdateAsync(Model);
            return new PermissionDetailWebResponse
            {


            };
        }
    }
}