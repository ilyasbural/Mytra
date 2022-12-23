namespace Mytra.Api.Controllers
{
    using Core;
    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    public class ContentTypeController : ControllerBase
    {
        readonly IContentTypeService Service;
        public ContentTypeController(IContentTypeService service)
        {
            Service = service;
        }

        [HttpPost]
        [Route("api/contenttype")]
        public async Task<Response<ContentType>> Create([FromBody] ContentTypeInsertDataTransfer Model)
        {
            await Service.InsertAsync(Model);
            return new Response<ContentType>
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
        [Route("api/contenttype")]
        public async Task<Response<ContentType>> Update([FromBody] ContentTypeUpdateDataTransfer Model)
        {
            await Service.UpdateAsync(Model);
            return new Response<ContentType>
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
        [Route("api/contenttype")]
        public async Task<Response<ContentType>> Delete([FromBody] ContentTypeDeleteDataTransfer Model)
        {
            await Service.DeleteAsync(Model);
            return new Response<ContentType>
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
        [Route("api/contenttype")]
        public async Task<Response<ContentType>> Get([FromBody] ContentTypeSelectDataTransfer Model)
        {
            await Service.SelectAsync(Model);
            return new Response<ContentType>
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
        [Route("api/contenttype/{id}")]
        public async Task<Response<ContentType>> Get([FromBody] ContentTypeAnyDataTransfer Model)
        {
            await Service.AnySelectAsync(Model);
            return new Response<ContentType>
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