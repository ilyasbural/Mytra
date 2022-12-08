namespace Mytra.Api.Controllers
{
    using Core;
    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    public class UserSettingsController : ControllerBase
    {
        private readonly IUserSettingsService Service;
        public UserSettingsController(IUserSettingsService service)
        {
            Service = service;
        }

        [HttpPost]
        [Route("api/usersettings")]
        public async Task<UserSettingsWebResponse> Create([FromBody] UserSettingsInsertDataTransfer Model)
        {
            UserSettingsResponse userSettingsResponse = await Service.InsertAsync(Model);
            return new UserSettingsWebResponse { UserSettings = userSettingsResponse.UserSettings };
        }

        [HttpPut]
        [Route("api/usersettings")]
        public async Task<UserSettingsWebResponse> Update([FromBody] UserSettingsUpdateDataTransfer Model)
        {
            UserSettingsResponse userSettingsResponse = await Service.UpdateAsync(Model);
            return new UserSettingsWebResponse
            {




            };
        }

        [HttpDelete]
        [Route("api/usersettings")]
        public async Task<UserSettingsWebResponse> Delete([FromBody] UserSettingsDeleteDataTransfer Model)
        {
            UserSettingsResponse userSettingsResponse = await Service.DeleteAsync(Model);
            return new UserSettingsWebResponse
            {




            };
        }

        [HttpGet]
        [Route("api/usersettings")]
        public async Task<UserSettingsWebResponse> Get([FromBody] UserSettingsSelectDataTransfer Model)
        {
            UserSettingsResponse userSettingsResponse = await Service.SelectAsync(Model);
            return new UserSettingsWebResponse
            {




            };
        }

        [HttpGet]
        [Route("api/usersettings/{id}")]
        public async Task<UserSettingsWebResponse> Get([FromBody] UserSettingsAnyDataTransfer Model)
        {
            UserSettingsResponse userSettingsResponse = await Service.AnyAsync(Model);
            return new UserSettingsWebResponse
            {




            };
        }
    }
}