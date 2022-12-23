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
        public async Task<Response<Content>> Create([FromBody] ContentInsertDataTransfer Model)
        {
            await Service.InsertAsync(Model);
            return new Response<Content>
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
        [Route("api/content")]
        public async Task<Response<Content>> Update([FromBody] ContentUpdateDataTransfer Model)
        {
            await Service.UpdateAsync(Model);
            return new Response<Content>
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
        [Route("api/content")]
        public async Task<Response<Content>> Delete([FromBody] ContentDeleteDataTransfer Model)
        {
            await Service.DeleteAsync(Model);
            return new Response<Content>
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
        [Route("api/content")]
        public async Task<Response<Content>> Get([FromBody] ContentSelectDataTransfer Model)
        {
            await Service.SelectAsync(Model);
            return new Response<Content>
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
        [Route("api/content/{id}")]
        public async Task<Response<Content>> Get([FromBody] ContentAnyDataTransfer Model)
        {
            await Service.AnySelectAsync(Model);
            return new Response<Content>
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