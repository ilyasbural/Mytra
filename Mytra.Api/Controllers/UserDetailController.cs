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
            return new UserDetailWebResponse { UserDetail = userDetailResponse.UserDetail };
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

        [HttpDelete]
        [Route("api/userdetail")]
        public async Task<UserDetailWebResponse> Delete([FromBody] UserDetailDeleteDataTransfer Model)
        {
            UserDetailResponse userDetailResponse = await Service.DeleteAsync(Model);
            return new UserDetailWebResponse
            {






            };
        }

        [HttpGet]
        [Route("api/userdetail")]
        public async Task<UserDetailWebResponse> Get([FromBody] UserDetailSelectDataTransfer Model)
        {
            UserDetailResponse userDetailResponse = await Service.SelectAsync(Model);
            return new UserDetailWebResponse
            {






            };
        }

        [HttpGet]
        [Route("api/userdetail/{id}")]
        public async Task<UserDetailWebResponse> Get([FromBody] UserDetailAnyDataTransfer Model)
        {
            UserDetailResponse userDetailResponse = await Service.AnyAsync(Model);
            return new UserDetailWebResponse
            {






            };
        }
    }
}