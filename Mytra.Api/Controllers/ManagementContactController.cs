namespace Mytra.Api.Controllers
{
    using Core;
    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    public class ManagementContactController : ControllerBase
    {
        private readonly IManagementContactService Service;
        public ManagementContactController(IManagementContactService service)
        {
            Service = service;
        }

        [HttpPost]
        [Route("api/managementcontact")]
        public async Task<ManagementContactWebResponse> Create([FromBody] ManagementContactInsertDataTransfer Model)
        {
            ManagementContactResponse managementContactResponse = await Service.InsertAsync(Model);
            return new ManagementContactWebResponse { Single = managementContactResponse.Single };
        }

        [HttpGet]
        [Route("api/managementcontact")]
        public async Task<ManagementContactWebResponse> Get([FromBody] ManagementContactSelectDataTransfer Model)
        {
            ManagementContactResponse managementContactResponse = await Service.SelectAsync(Model);
            return new ManagementContactWebResponse { Single = managementContactResponse.Single };
        }

        [HttpGet]
        [Route("api/managementcontact/{id}")]
        public async Task<ManagementContactWebResponse> Get([FromBody] ManagementContactAnyDataTransfer Model)
        {
            ManagementContactResponse managementContactResponse = await Service.AnyAsync(Model);
            return new ManagementContactWebResponse
            {





            };
        }
    }
}