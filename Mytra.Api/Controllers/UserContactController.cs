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
            UserContactResponse userContactResponse = await Service.InsertAsync(Model);
            return new UserContactWebResponse { UserContact = userContactResponse.UserContact };
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

        [HttpDelete]
        [Route("api/usercontact")]
        public async Task<UserContactWebResponse> Delete([FromBody] UserContactDeleteDataTransfer Model)
        {
            UserContactResponse userContactResponse = await Service.DeleteAsync(Model);
            return new UserContactWebResponse
            {



            };
        }

        [HttpGet]
        [Route("api/usercontact")]
        public async Task<UserContactWebResponse> Get([FromBody] UserContactSelectDataTransfer Model)
        {
            UserContactResponse userContactResponse = await Service.SelectAsync(Model);
            return new UserContactWebResponse
            {



            };
        }

        [HttpGet]
        [Route("api/usercontact/{id}")]
        public async Task<UserContactWebResponse> Get([FromBody] UserContactAnyDataTransfer Model)
        {
            UserContactResponse userContactResponse = await Service.AnyAsync(Model);
            return new UserContactWebResponse
            {



            };
        }
    }
}