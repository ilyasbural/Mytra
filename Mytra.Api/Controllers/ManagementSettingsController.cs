namespace Mytra.Api.Controllers
{
    using Core;
    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    public class ManagementSettingsController : ControllerBase
    {
        private readonly IManagementSettingsService Service;
        public ManagementSettingsController(IManagementSettingsService service)
        {
            Service = service;
        }

        [HttpPost]
        [Route("api/managementsettings")]
        public async Task<ManagementSettingsWebResponse> Create([FromBody] ManagementSettingsInsertDataTransfer Model)
        {
            ManagementSettingsResponse managementSettingsResponse = await Service.InsertAsync(Model);
            return new ManagementSettingsWebResponse { Single = managementSettingsResponse.Single };
        }

        [HttpPut]
        [Route("api/managementsettings")]
        public async Task<ManagementSettingsWebResponse> Update([FromBody] ManagementSettingsUpdateDataTransfer Model)
        {
            ManagementSettingsResponse managementSettingsResponse = await Service.UpdateAsync(Model);
            return new ManagementSettingsWebResponse { Single = managementSettingsResponse.Single };
        }

        [HttpDelete]
        [Route("api/managementsettings")]
        public async Task<ManagementSettingsWebResponse> Delete([FromBody] ManagementSettingsDeleteDataTransfer Model)
        {
            ManagementSettingsResponse managementSettingsResponse = await Service.DeleteAsync(Model);
            return new ManagementSettingsWebResponse
            {


            };
        }

        [HttpGet]
        [Route("api/managementsettings")]
        public async Task<ManagementSettingsWebResponse> Get([FromBody] ManagementSettingsSelectDataTransfer Model)
        {
            ManagementSettingsResponse managementSettingsResponse = await Service.SelectAsync(Model);
            return new ManagementSettingsWebResponse
            {


            };
        }

        [HttpGet]
        [Route("api/managementsettings/{id}")]
        public async Task<ManagementSettingsWebResponse> Get([FromBody] ManagementSettingsAnyDataTransfer Model)
        {
            ManagementSettingsResponse managementSettingsResponse = await Service.AnyAsync(Model);
            return new ManagementSettingsWebResponse
            {


            };
        }
    }
}