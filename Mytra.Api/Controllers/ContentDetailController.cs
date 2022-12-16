namespace Mytra.Api.Controllers
{
    using Core;
    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    public class ContentDetailController : ControllerBase
    {
        readonly IContentDetailService Service;
        public ContentDetailController(IContentDetailService service)
        {
            Service = service;
        }

        [HttpPost]
        [Route("api/contentdetail")]
        public async Task<ContentDetailWebResponse> Create([FromBody] ContentDetailInsertDataTransfer Model)
        {
            ContentDetailResponse contentDetailResponse = await Service.InsertAsync(Model);
            return new ContentDetailWebResponse 
            { 
                Single = contentDetailResponse.Single, 
                Success = contentDetailResponse.Success 
            };
        }

        [HttpPut]
        [Route("api/contentdetail")]
        public async Task<ContentDetailWebResponse> Update([FromBody] ContentDetailUpdateDataTransfer Model)
        {
            ContentDetailResponse contentDetailResponse = await Service.UpdateAsync(Model);
            return new ContentDetailWebResponse { Single = contentDetailResponse.Single };
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
                List = contentDetailResponse.List,
                Success = contentDetailResponse.Success, 
                Message = contentDetailResponse.Message
            };
        }

        [HttpGet]
        [Route("api/contentdetail/{id}")]
        public async Task<ContentDetailWebResponse> Get([FromBody] ContentDetailAnyDataTransfer Model)
        {
            ContentDetailResponse contentDetailResponse = await Service.AnyAsync(Model);
            return new ContentDetailWebResponse
            {
                List = contentDetailResponse.List,
                Success = contentDetailResponse.Success,
                Message = contentDetailResponse.Message
            };
        }
    }
}