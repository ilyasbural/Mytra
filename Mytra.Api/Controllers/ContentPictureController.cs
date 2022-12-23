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
            await Service.InsertAsync(Model);
            return new Response<ContentPicture>
            {
                //Single = Response.Entity,
                //Success = Success,
                //Message = Message,
                //Errors = new List<string>(),
                //IsValidationError = IsValidationError,
                //Validations = new List<ValidationResult> { Validations }
            };
        }

        [HttpPut]
        [Route("api/contentpicture")]
        public async Task<Response<ContentPicture>> Update([FromBody] ContentPictureUpdateDataTransfer Model)
        {
            await Service.UpdateAsync(Model);
            return new Response<ContentPicture>
            {
                //Single = Response.Entity,
                //Success = Success,
                //Message = Message,
                //Errors = new List<string>(),
                //IsValidationError = IsValidationError,
                //Validations = new List<ValidationResult> { Validations }
            };
        }

        [HttpDelete]
        [Route("api/contentpicture")]
        public async Task<Response<ContentPicture>> Delete([FromBody] ContentPictureDeleteDataTransfer Model)
        {
            await Service.DeleteAsync(Model);
            return new Response<ContentPicture>
            {
                //Single = Response.Entity,
                //Success = Success,
                //Message = Message,
                //Errors = new List<string>(),
                //IsValidationError = IsValidationError,
                //Validations = new List<ValidationResult> { Validations }
            };
        }

        [HttpGet]
        [Route("api/contentpicture")]
        public async Task<Response<ContentPicture>> Get([FromBody] ContentPictureSelectDataTransfer Model)
        {
            await Service.SelectAsync(Model);
            return new Response<ContentPicture>
            {
                //Single = Response.Entity,
                //Success = Success,
                //Message = Message,
                //Errors = new List<string>(),
                //IsValidationError = IsValidationError,
                //Validations = new List<ValidationResult> { Validations }
            };
        }

        [HttpGet]
        [Route("api/contentpicture/{id}")]
        public async Task<Response<ContentPicture>> Get([FromBody] ContentPictureAnyDataTransfer Model)
        {
            await Service.AnySelectAsync(Model);
            return new Response<ContentPicture>
            {
                //Single = Response.Entity,
                //Success = Success,
                //Message = Message,
                //Errors = new List<string>(),
                //IsValidationError = IsValidationError,
                //Validations = new List<ValidationResult> { Validations }
            };
        }
    }
}