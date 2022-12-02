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
            return new ContentDetailWebResponse
            {
                




            };
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
    }
}