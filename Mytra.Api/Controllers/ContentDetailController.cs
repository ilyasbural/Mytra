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
        public async Task<Response<ContentDetail>> Create([FromBody] ContentDetailInsertDataTransfer Model)
        {
            Response<ContentDetail> Response = await Service.InsertAsync(Model);
            return new Response<ContentDetail>
            {
                Data = Response.Data,
                Message = Response.Message,
                Success = Response.Success,
                IsValidationError = Response.IsValidationError
            };
        }

        [HttpPut]
        [Route("api/contentdetail")]
        public async Task<Response<ContentDetail>> Update([FromBody] ContentDetailUpdateDataTransfer Model)
        {
            Response<ContentDetail> Response = await Service.UpdateAsync(Model);
            return new Response<ContentDetail>
            {
                Data = Response.Data,
                Message = Response.Message,
                Success = Response.Success,
                IsValidationError = Response.IsValidationError
            };
        }

        [HttpDelete]
        [Route("api/contentdetail")]
        public async Task<Response<ContentDetail>> Delete([FromBody] ContentDetailDeleteDataTransfer Model)
        {
            Response<ContentDetail> Response = await Service.DeleteAsync(Model);
            return new Response<ContentDetail>
            {
                Data = Response.Data,
                Message = Response.Message,
                Success = Response.Success,
                IsValidationError = Response.IsValidationError
            };
        }

        [HttpGet]
        [Route("api/contentdetail")]
        public async Task<Response<ContentDetail>> Get([FromBody] ContentDetailSelectDataTransfer Model)
        {
            Response<ContentDetail> Response = await Service.SelectAsync(Model);
            return new Response<ContentDetail>
            {
                Collection = Response.Collection,
                Message = Response.Message,
                Success = Response.Success,
                IsValidationError = Response.IsValidationError
            };
        }

        [HttpGet]
        [Route("api/contentdetail/{id}")]
        public async Task<Response<ContentDetail>> Get([FromBody] ContentDetailAnyDataTransfer Model)
        {
            Response<ContentDetail> Response = await Service.AnySelectAsync(Model);
            return new Response<ContentDetail>
            {
                Collection = Response.Collection,
                Message = Response.Message,
                Success = Response.Success,
                IsValidationError = Response.IsValidationError
            };
        }
    }
}