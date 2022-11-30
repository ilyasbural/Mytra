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
    }
}