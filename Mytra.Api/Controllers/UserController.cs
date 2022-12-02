namespace Mytra.Api.Controllers
{
    using Core;
    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService Service;
        public UserController(IUserService service)
        {
            Service = service;
        }

        [HttpPost]
        [Route("api/user")]
        public async Task<UserWebResponse> Create([FromBody] UserInsertDataTransfer Model)
        {
            UserResponse userResponse = await Service.AddAsync(Model);
            return new UserWebResponse
            {
                


            };
        }

        [HttpPut]
        [Route("api/user")]
        public async Task<UserWebResponse> Update([FromBody] UserUpdateDataTransfer Model)
        {
            UserResponse userResponse = await Service.UpdateAsync(Model);
            return new UserWebResponse
            {



            };
        }

        [HttpPut]
        [Route("api/user")]
        public async Task<UserWebResponse> Delete([FromBody] UserDeleteDataTransfer Model)
        {
            UserResponse userResponse = await Service.DeleteAsync(Model);
            return new UserWebResponse
            {



            };
        }
    }
}