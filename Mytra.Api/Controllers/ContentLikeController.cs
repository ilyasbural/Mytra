namespace Mytra.Api.Controllers
{
    using Core;
    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    public class ContentLikeController : ControllerBase
    {
        private readonly IContentLikeService Service;
        public ContentLikeController(IContentLikeService service)
        {
            Service = service;
        }

        [HttpPost]
        [Route("api/contentlike")]
        public async Task<ContentLikeWebResponse> Create([FromBody] ContentLikeInsertDataTransfer Model)
        {
            ContentLikeResponse contentLikeResponse = await Service.AddAsync(Model);
            return new ContentLikeWebResponse
            {
                





            };
        }

        [HttpPut]
        [Route("api/contentlike")]
        public async Task<ContentLikeWebResponse> Update([FromBody] ContentLikeUpdateDataTransfer Model)
        {
            ContentLikeResponse contentLikeResponse = await Service.UpdateAsync(Model);
            return new ContentLikeWebResponse
            {






            };
        }

        [HttpDelete]
        [Route("api/contentlike")]
        public async Task<ContentLikeWebResponse> Delete([FromBody] ContentLikeDeleteDataTransfer Model)
        {
            ContentLikeResponse contentLikeResponse = await Service.DeleteAsync(Model);
            return new ContentLikeWebResponse
            {






            };
        }
    }
}