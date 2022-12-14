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
            UserResponse userResponse = await Service.InsertAsync(Model);
            return new UserWebResponse { Single = userResponse.Single };
        }

        [HttpPut]
        [Route("api/user")]
        public async Task<UserWebResponse> Update([FromBody] UserUpdateDataTransfer Model)
        {
            UserResponse userResponse = await Service.UpdateAsync(Model);
            return new UserWebResponse { Single = userResponse.Single };
        }

        [HttpDelete]
        [Route("api/user")]
        public async Task<UserWebResponse> Delete([FromBody] UserDeleteDataTransfer Model)
        {
            UserResponse userResponse = await Service.DeleteAsync(Model);
            return new UserWebResponse
            {



            };
        }

        [HttpGet]
        [Route("api/user")]
        public async Task<UserWebResponse> Get([FromBody] UserSelectDataTransfer Model)
        {
            UserResponse userResponse = await Service.SelectAsync(Model);
            return new UserWebResponse
            {



            };
        }

        [HttpGet]
        [Route("api/user/{id}")]
        public async Task<UserWebResponse> Get([FromBody] UserAnyDataTransfer Model)
        {
            UserResponse userResponse = await Service.AnyAsync(Model);
            return new UserWebResponse
            {



            };
        }
    }
}