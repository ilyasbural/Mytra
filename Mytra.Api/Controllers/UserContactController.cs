namespace Mytra.Api.Controllers
{
    using Core;
    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    public class UserContactController : ControllerBase
    {
        private readonly IUserContactService Service;
        public UserContactController(IUserContactService service)
        {
            Service = service;
        }

        [HttpPost]
        [Route("api/usercontact")]
        public async Task<UserContactWebResponse> Create([FromBody] UserContactInsertDataTransfer Model)
        {
            UserContactResponse userContactResponse = await Service.AddAsync(Model);
            return new UserContactWebResponse
            {
                


            };
        }

        [HttpPut]
        [Route("api/usercontact")]
        public async Task<UserContactWebResponse> Update([FromBody] UserContactUpdateDataTransfer Model)
        {
            UserContactResponse userContactResponse = await Service.UpdateAsync(Model);
            return new UserContactWebResponse
            {



            };
        }

        [HttpPut]
        [Route("api/usercontact")]
        public async Task<UserContactWebResponse> Delete([FromBody] UserContactDeleteDataTransfer Model)
        {
            UserContactResponse userContactResponse = await Service.DeleteAsync(Model);
            return new UserContactWebResponse
            {



            };
        }
    }
}