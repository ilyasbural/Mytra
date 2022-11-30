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
            ManagementSettingsResponse managementSettingsResponse = await Service.AddAsync(Model);
            return new ManagementSettingsWebResponse
            {
                




            };
        }
    }
}