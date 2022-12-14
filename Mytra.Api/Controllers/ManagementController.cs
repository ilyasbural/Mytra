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
            ManagementResponse managementResponse = await Service.InsertAsync(Model);
            return new ManagementWebResponse { Single = managementResponse.Single };
        }

        [HttpPut]
        [Route("api/management")]
        public async Task<ManagementWebResponse> Update([FromBody] ManagementUpdateDataTransfer Model)
        {
            ManagementResponse managementResponse = await Service.UpdateAsync(Model);
            return new ManagementWebResponse { Single = managementResponse.Single };
        }

        [HttpDelete]
        [Route("api/management")]
        public async Task<ManagementWebResponse> Delete([FromBody] ManagementDeleteDataTransfer Model)
        {
            ManagementResponse managementResponse = await Service.DeleteAsync(Model);
            return new ManagementWebResponse
            {





            };
        }

        [HttpGet]
        [Route("api/management")]
        public async Task<ManagementWebResponse> Get([FromBody] ManagementSelectDataTransfer Model)
        {
            ManagementResponse managementResponse = await Service.SelectAsync(Model);
            return new ManagementWebResponse
            {





            };
        }

        [HttpGet]
        [Route("api/management/{id}")]
        public async Task<ManagementWebResponse> Get([FromBody] ManagementAnyDataTransfer Model)
        {
            ManagementResponse managementResponse = await Service.AnyAsync(Model);
            return new ManagementWebResponse
            {





            };
        }
    }
}