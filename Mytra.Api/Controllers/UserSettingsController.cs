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
            UserSettingsResponse userSettingsResponse = await Service.AddAsync(Model);
            return new UserSettingsWebResponse
            {
                







            };
        }
    }
}