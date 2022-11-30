namespace Mytra.Api.Controllers
{
    using Core;
    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    public class ManagementDetailController : ControllerBase
    {
        private readonly IManagementDetailService Service;
        public ManagementDetailController(IManagementDetailService service)
        {
            Service = service;
        }

        [HttpPost]
        [Route("api/managementdetail")]
        public async Task<ManagementDetailWebResponse> Create([FromBody] ManagementDetailInsertDataTransfer Model)
        {
            ManagementDetailResponse managementDetailResponse = await Service.AddAsync(Model);
            return new ManagementDetailWebResponse
            {
                




            };
        }
    }
}