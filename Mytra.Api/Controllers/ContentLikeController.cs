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
    }
}