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
        public async Task<ContentSettingsWebResponse> Create([FromBody] ContentSettingsInsertDataTransfer Model)
        {
            ContentSettingsResponse contentSettingsResponse = await Service.AddAsync(Model);
            return new ContentSettingsWebResponse
            {
                




            };
        }
    }
}