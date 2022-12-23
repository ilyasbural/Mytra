namespace Mytra.Api.Controllers
{
    using Core;
    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    public class ContentLikeController : ControllerBase
    {
        readonly IContentLikeService Service;
        public ContentLikeController(IContentLikeService service)
        {
            Service = service;
        }

        [HttpPost]
        [Route("api/contentlike")]
        public async Task<Response<ContentLike>> Create([FromBody] ContentLikeInsertDataTransfer Model)
        {
            await Service.InsertAsync(Model);
            return new Response<ContentLike>
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
        [Route("api/contentlike")]
        public async Task<Response<ContentLike>> Update([FromBody] ContentLikeUpdateDataTransfer Model)
        {
            await Service.UpdateAsync(Model);
            return new Response<ContentLike>
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
        [Route("api/contentlike")]
        public async Task<Response<ContentLike>> Delete([FromBody] ContentLikeDeleteDataTransfer Model)
        {
            await Service.DeleteAsync(Model);
            return new Response<ContentLike>
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
        [Route("api/contentlike")]
        public async Task<Response<ContentLike>> Get([FromBody] ContentLikeSelectDataTransfer Model)
        {
            await Service.SelectAsync(Model);
            return new Response<ContentLike>
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
        [Route("api/contentlike/{id}")]
        public async Task<Response<ContentLike>> Get([FromBody] ContentLikeAnyDataTransfer Model)
        {
            await Service.AnySelectAsync(Model);
            return new Response<ContentLike>
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