namespace Mytra.Api.Controllers
{
    using Core;
    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    public class ContentPictureController : ControllerBase
    {
        readonly IContentPictureService Service;
        public ContentPictureController(IContentPictureService service)
        {
            Service = service;
        }

        [HttpPost]
        [Route("api/contentpicture")]
        public async Task<Response<ContentPicture>> Create([FromBody] ContentPictureInsertDataTransfer Model)
        {
            Response<ContentPicture> Response = await Service.InsertAsync(Model);
            return new Response<ContentPicture>
            {
                Data = Response.Data,
                Message = Response.Message,
                Success = Response.Success,
                IsValidationError = Response.IsValidationError
            };
        }

        [HttpPut]
        [Route("api/contentpicture")]
        public async Task<Response<ContentPicture>> Update([FromBody] ContentPictureUpdateDataTransfer Model)
        {
            Response<ContentPicture> Response = await Service.UpdateAsync(Model);
            return new Response<ContentPicture>
            {
                Data = Response.Data,
                Message = Response.Message,
                Success = Response.Success,
                IsValidationError = Response.IsValidationError
            };
        }

        [HttpDelete]
        [Route("api/contentpicture")]
        public async Task<Response<ContentPicture>> Delete([FromBody] ContentPictureDeleteDataTransfer Model)
        {
            Response<ContentPicture> Response = await Service.DeleteAsync(Model);
            return new Response<ContentPicture>
            {
                Data = Response.Data,
                Message = Response.Message,
                Success = Response.Success,
                IsValidationError = Response.IsValidationError
            };
        }

        [HttpGet]
        [Route("api/contentpicture")]
        public async Task<Response<ContentPicture>> Get([FromBody] ContentPictureSelectDataTransfer Model)
        {
            Response<ContentPicture> Response = await Service.SelectAsync(Model);
            return new Response<ContentPicture>
            {
                Collection = Response.Collection,
                Message = Response.Message,
                Success = Response.Success,
                IsValidationError = Response.IsValidationError
            };
        }

        [HttpGet]
        [Route("api/contentpicture/{id}")]
        public async Task<Response<ContentPicture>> Get([FromBody] ContentPictureAnyDataTransfer Model)
        {
            Response<ContentPicture> Response = await Service.AnySelectAsync(Model);
            return new Response<ContentPicture>
            {
                Collection = Response.Collection,
                Message = Response.Message,
                Success = Response.Success,
                IsValidationError = Response.IsValidationError
            };
        }
    }
}