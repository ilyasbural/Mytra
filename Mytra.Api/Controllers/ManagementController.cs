namespace Mytra.Api.Controllers
{
    using Core;
    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    public class ManagementController : ControllerBase
    {
        private readonly IManagementService Service;
        public ManagementController(IManagementService service)
        {
            Service = service;
        }

        [HttpPost]
        [Route("api/management")]
        public async Task<ManagementWebResponse> Create([FromBody] ManagementInsertDataTransfer Model)
        {
            ManagementResponse managementResponse = await Service.AddAsync(Model);
            return new ManagementWebResponse
            {
                




            };
        }

        [HttpPut]
        [Route("api/management")]
        public async Task<ManagementWebResponse> Update([FromBody] ManagementUpdateDataTransfer Model)
        {
            ManagementResponse managementResponse = await Service.UpdateAsync(Model);
            return new ManagementWebResponse
            {





            };
        }
    }
}