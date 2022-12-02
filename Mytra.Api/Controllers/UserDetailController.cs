namespace Mytra.Api.Controllers
{
    using Core;
    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    public class UserDetailController : ControllerBase
    {
        private readonly IUserDetailService Service;
        public UserDetailController(IUserDetailService service)
        {
            Service = service;
        }

        [HttpPost]
        [Route("api/userdetail")]
        public async Task<UserDetailWebResponse> Create([FromBody] UserDetailInsertDataTransfer Model)
        {
            UserDetailResponse userDetailResponse = await Service.AddAsync(Model);
            return new UserDetailWebResponse
            {
                





            };
        }

        [HttpPut]
        [Route("api/userdetail")]
        public async Task<UserDetailWebResponse> Update([FromBody] UserDetailUpdateDataTransfer Model)
        {
            UserDetailResponse userDetailResponse = await Service.UpdateAsync(Model);
            return new UserDetailWebResponse
            {






            };
        }
    }
}