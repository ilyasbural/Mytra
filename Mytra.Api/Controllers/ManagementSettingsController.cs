namespace Mytra.Api.Controllers
{
    using Core;
    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    public class ManagementSettingsController : ControllerBase
    {
        private readonly IManagementSettingsService Service;
        public ManagementSettingsController(IManagementSettingsService service)
        {
            Service = service;
        }

        [HttpPost]
        [Route("api/managementsettings")]
        public Task<ManagementSettingsWebResponse> Create([FromBody] ManagementSettingsInsertDataTransfer Model)
        {
            Task<ManagementSettingsResponse> Data = Service.AddAsync(Model);
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