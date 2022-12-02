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
    }
}