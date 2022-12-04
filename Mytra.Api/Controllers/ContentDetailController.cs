namespace Mytra.Api.Controllers
{
    using Core;
    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    public class ContentDetailController : ControllerBase
    {
        private readonly IContentDetailService Service;
        public ContentDetailController(IContentDetailService service)
        {
            Service = service;
        }

        [HttpPost]
        [Route("api/contentdetail")]
        public async Task<ContentDetailWebResponse> Create([FromBody] ContentDetailInsertDataTransfer Model)
        {
            ContentDetailResponse contentDetailResponse = await Service.AddAsync(Model);
            return new ContentDetailWebResponse { ContentDetail = contentDetailResponse.ContentDetail };
        }

        [HttpPut]
        [Route("api/contentdetail")]
        public async Task<ContentDetailWebResponse> Update([FromBody] ContentDetailUpdateDataTransfer Model)
        {
            ContentDetailResponse contentDetailResponse = await Service.UpdateAsync(Model);
            return new ContentDetailWebResponse
            {





            };
        }

        [HttpDelete]
        [Route("api/contentdetail")]
        public async Task<ContentDetailWebResponse> Delete([FromBody] ContentDetailDeleteDataTransfer Model)
        {
            ContentDetailResponse contentDetailResponse = await Service.DeleteAsync(Model);
            return new ContentDetailWebResponse
            {





            };
        }

        [HttpGet]
        [Route("api/contentdetail")]
        public async Task<ContentDetailWebResponse> Get([FromBody] ContentDetailSelectDataTransfer Model)
        {
            ContentDetailResponse contentDetailResponse = await Service.SelectAsync(Model);
            return new ContentDetailWebResponse
            {





            };
        }

        [HttpGet]
        [Route("api/contentdetail/{id}")]
        public async Task<ContentDetailWebResponse> Get([FromBody] ContentDetailAnyDataTransfer Model)
        {
            ContentDetailResponse contentDetailResponse = await Service.AnyAsync(Model);
            return new ContentDetailWebResponse
            {





            };
        }
    }
}