namespace Mytra.Api.Controllers
{
    using Core;
    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    public class ContentPictureController : ControllerBase
    {
        private readonly IContentPictureService Service;
        public ContentPictureController(IContentPictureService service)
        {
            Service = service;
        }

        [HttpPost]
        [Route("api/contentpicture")]
        public async Task<ContentPictureWebResponse> Create([FromBody] ContentPictureInsertDataTransfer Model)
        {
            ContentPictureResponse contentPictureResponse = await Service.AddAsync(Model);
            return new ContentPictureWebResponse
            {
                





            };
        }
    }
}