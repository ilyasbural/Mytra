namespace Mytra.Api.Controllers
{
    using Core;
    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    public class ContentController : ControllerBase
    {
        private readonly IContentService Service;
        public ContentController(IContentService service)
        {
            Service = service;
        }

        [HttpPost]
        [Route("api/content")]
        public async Task<ContentWebResponse> Create([FromBody] ContentInsertDataTransfer Model)
        {
            ContentResponse contentResponse = await Service.AddAsync(Model);
            return new ContentWebResponse
            {
               




            };
        }

        [HttpPut]
        [Route("api/content")]
        public async Task<ContentWebResponse> Update([FromBody] ContentUpdateDataTransfer Model)
        {
            ContentResponse contentResponse = await Service.UpdateAsync(Model);
            return new ContentWebResponse
            {





            };
        }
    }
}