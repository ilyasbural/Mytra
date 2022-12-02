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
            ManagementContactResponse managementContactResponse = await Service.AddAsync(Model);
            return new ManagementContactWebResponse
            {
                




            };
        }

        [HttpPut]
        [Route("api/managementcontact")]
        public async Task<ManagementContactWebResponse> Update([FromBody] ManagementContactUpdateDataTransfer Model)
        {
            ManagementContactResponse managementContactResponse = await Service.UpdateAsync(Model);
            return new ManagementContactWebResponse
            {





            };
        }
    }
}