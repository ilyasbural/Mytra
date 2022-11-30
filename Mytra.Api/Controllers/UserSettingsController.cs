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
        public Task<UserSettingsWebResponse> Create([FromBody] UserSettingsInsertDataTransfer Model)
        {
            Task<UserSettingsResponse> Data = Service.AddAsync(Model);
            //AnnounceResult Result = Service.AddAsync(Model);
            //return new AnnounceResponse
            //{
            //    Id = Result.Id,
            //    Company = Result.Company,
            //    Occupation = Result.Occupation,
            //    Title = Result.Title,
            //    AnnounceDate = Result.AnnounceDate,
            //    CreatedByUser = Result.CreatedByUser,
            //    UpdatedByUser = Result.UpdatedByUser,
            //    RegisterDate = Result.RegisterDate,
            //    UpdateDate = Result.UpdateDate
            //};
            return Create(Model);
        }
    }
}