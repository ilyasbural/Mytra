namespace Mytra.Api.Controllers
{
    using Core;
    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    public class ContentSettingsController : ControllerBase
    {
        private readonly IContentSettingsService Service;
        public ContentSettingsController(IContentSettingsService service)
        {
            Service = service;
        }

        [HttpPost]
        [Route("api/contentsettings")]
        public Task<ContentSettingsWebResponse> Create([FromBody] ContentSettingsInsertDataTransfer Model)
        {
            Task<ContentSettingsResponse> Data = Service.AddAsync(Model);
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