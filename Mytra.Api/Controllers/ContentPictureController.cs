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

        [HttpPut]
        [Route("api/contentpicture")]
        public async Task<ContentPictureWebResponse> Update([FromBody] ContentPictureUpdateDataTransfer Model)
        {
            ContentPictureResponse contentPictureResponse = await Service.UpdateAsync(Model);
            return new ContentPictureWebResponse
            {






            };
        }

        [HttpDelete]
        [Route("api/contentpicture")]
        public async Task<ContentPictureWebResponse> Delete([FromBody] ContentPictureDeleteDataTransfer Model)
        {
            ContentPictureResponse contentPictureResponse = await Service.DeleteAsync(Model);
            return new ContentPictureWebResponse
            {






            };
        }

        [HttpGet]
        [Route("api/contentpicture")]
        public async Task<ContentPictureWebResponse> Get([FromBody] ContentPictureSelectDataTransfer Model)
        {
            ContentPictureResponse contentPictureResponse = await Service.SelectAsync(Model);
            return new ContentPictureWebResponse
            {






            };
        }

        [HttpGet]
        [Route("api/contentpicture/{id}")]
        public async Task<ContentPictureWebResponse> Get([FromBody] ContentPictureAnyDataTransfer Model)
        {
            ContentPictureResponse contentPictureResponse = await Service.AnyAsync(Model);
            return new ContentPictureWebResponse
            {






            };
        }
    }
}