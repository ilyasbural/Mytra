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

        [HttpPut]
        [Route("api/contentsettings")]
        public async Task<ContentSettingsWebResponse> Update([FromBody] ContentSettingsUpdateDataTransfer Model)
        {
            ContentSettingsResponse contentSettingsResponse = await Service.UpdateAsync(Model);
            return new ContentSettingsWebResponse
            {





            };
        }

        [HttpDelete]
        [Route("api/contentsettings")]
        public async Task<ContentSettingsWebResponse> Delete([FromBody] ContentSettingsDeleteDataTransfer Model)
        {
            ContentSettingsResponse contentSettingsResponse = await Service.DeleteAsync(Model);
            return new ContentSettingsWebResponse
            {





            };
        }

        [HttpGet]
        [Route("api/contentsettings")]
        public async Task<ContentSettingsWebResponse> Get([FromBody] ContentSettingsSelectDataTransfer Model)
        {
            ContentSettingsResponse contentSettingsResponse = await Service.SelectAsync(Model);
            return new ContentSettingsWebResponse
            {





            };
        }

        [HttpGet]
        [Route("api/contentsettings/{id]")]
        public async Task<ContentSettingsWebResponse> Get([FromBody] ContentSettingsAnyDataTransfer Model)
        {
            ContentSettingsResponse contentSettingsResponse = await Service.AnyAsync(Model);
            return new ContentSettingsWebResponse
            {





            };
        }
    }
}