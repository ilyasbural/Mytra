namespace Mytra.Api.Controllers
{
    using Core;
    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    public class ContentController : ControllerBase
    {
        readonly IContentService Service;
        public ContentController(IContentService service)
        {
            Service = service;
        }

        [HttpPost]
        [Route("api/content")]
        public async Task<ContentWebResponse> Create([FromBody] ContentInsertDataTransfer Model)
        {
            ContentResponse contentResponse = await Service.InsertAsync(Model);
            return new ContentWebResponse 
            { 
                Single = contentResponse.Single, 
                Success = contentResponse.Success  
            };
        }

        [HttpPut]
        [Route("api/content")]
        public async Task<ContentWebResponse> Update([FromBody] ContentUpdateDataTransfer Model)
        {
            ContentResponse contentResponse = await Service.UpdateAsync(Model);
            return new ContentWebResponse { Single = contentResponse.Single };
        }

        [HttpDelete]
        [Route("api/content")]
        public async Task<ContentWebResponse> Delete([FromBody] ContentDeleteDataTransfer Model)
        {
            ContentResponse contentResponse = await Service.DeleteAsync(Model);
            return new ContentWebResponse
            {





            };
        }

        [HttpGet]
        [Route("api/content")]
        public async Task<ContentWebResponse> Get([FromBody] ContentSelectDataTransfer Model)
        {
            ContentResponse contentResponse = await Service.SelectAsync(Model);
            return new ContentWebResponse
            {
                List = contentResponse.List,
                Success = contentResponse.Success, 
                Message = contentResponse.Message
            };
        }

        [HttpGet]
        [Route("api/content/{id}")]
        public async Task<ContentWebResponse> Get([FromBody] ContentAnyDataTransfer Model)
        {
            ContentResponse contentResponse = await Service.AnyAsync(Model);
            return new ContentWebResponse
            {
                List = contentResponse.List,
                Success = contentResponse.Success,
                Message = contentResponse.Message
            };
        }
    }
}