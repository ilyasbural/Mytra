namespace Mytra.Api.Controllers
{
    using Core;
    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    public class ContentTypeController : ControllerBase
    {
        private readonly IContentTypeService Service;
        public ContentTypeController(IContentTypeService service)
        {
            Service = service;
        }

        [HttpPost]
        [Route("api/contenttype")]
        public async Task<ContentTypeWebResponse> Create([FromBody] ContentTypeInsertDataTransfer Model)
        {
            ContentTypeResponse contentTypeResponse = await Service.AddAsync(Model);
            return new ContentTypeWebResponse
            {
                





            };
        }

        [HttpPut]
        [Route("api/contenttype")]
        public async Task<ContentTypeWebResponse> Update([FromBody] ContentTypeUpdateDataTransfer Model)
        {
            ContentTypeResponse contentTypeResponse = await Service.UpdateAsync(Model);
            return new ContentTypeWebResponse
            {






            };
        }

        [HttpDelete]
        [Route("api/contenttype")]
        public async Task<ContentTypeWebResponse> Delete([FromBody] ContentTypeDeleteDataTransfer Model)
        {
            ContentTypeResponse contentTypeResponse = await Service.DeleteAsync(Model);
            return new ContentTypeWebResponse
            {






            };
        }

        [HttpGet]
        [Route("api/contenttype")]
        public async Task<ContentTypeWebResponse> Get([FromBody] ContentTypeSelectDataTransfer Model)
        {
            ContentTypeResponse contentTypeResponse = await Service.SelectAsync(Model);
            return new ContentTypeWebResponse
            {






            };
        }

        [HttpGet]
        [Route("api/contenttype/{id}")]
        public async Task<ContentTypeWebResponse> Get([FromBody] ContentTypeAnyDataTransfer Model)
        {
            ContentTypeResponse contentTypeResponse = await Service.AnyAsync(Model);
            return new ContentTypeWebResponse
            {






            };
        }
    }
}