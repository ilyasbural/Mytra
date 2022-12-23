namespace Mytra.Api.Controllers
{
    using Core;
    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    public class ContentCommentController : ControllerBase
    {
        readonly IContentCommentService Service;
        public ContentCommentController(IContentCommentService service)
        {
            Service = service;
        }

        [HttpPost]
        [Route("api/contentcomment")]
        public async Task<Response<ContentComment>> Create([FromBody] ContentCommentInsertDataTransfer Model)
        {
            await Service.InsertAsync(Model);
            return new Response<ContentComment>
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
        [Route("api/contentcomment")]
        public async Task<Response<ContentComment>> Update([FromBody] ContentCommentUpdateDataTransfer Model)
        {
            await Service.UpdateAsync(Model);
            return new Response<ContentComment>
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
        [Route("api/contentcomment")]
        public async Task<Response<ContentComment>> Delete([FromBody] ContentCommentDeleteDataTransfer Model)
        {
            await Service.DeleteAsync(Model);
            return new Response<ContentComment>
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
        [Route("api/contentcomment")]
        public async Task<Response<ContentComment>> Get([FromBody] ContentCommentSelectDataTransfer Model)
        {
            await Service.SelectAsync(Model);
            return new Response<ContentComment>
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
        [Route("api/contentcomment/{id}")]
        public async Task<Response<ContentComment>> Get([FromBody] ContentCommentAnyDataTransfer Model)
        {
            await Service.AnySelectAsync(Model);
            return new Response<ContentComment>
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