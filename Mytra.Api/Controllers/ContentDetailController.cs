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
            await Service.InsertAsync(Model);
            return new Response<ContentDetail>
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
        [Route("api/contentdetail")]
        public async Task<Response<ContentDetail>> Update([FromBody] ContentDetailUpdateDataTransfer Model)
        {
            await Service.UpdateAsync(Model);
            return new Response<ContentDetail>
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
        [Route("api/contentdetail")]
        public async Task<Response<ContentDetail>> Delete([FromBody] ContentDetailDeleteDataTransfer Model)
        {
            await Service.DeleteAsync(Model);
            return new Response<ContentDetail>
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
        [Route("api/contentdetail")]
        public async Task<Response<ContentDetail>> Get([FromBody] ContentDetailSelectDataTransfer Model)
        {
            await Service.SelectAsync(Model);
            return new Response<ContentDetail>
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
        [Route("api/contentdetail/{id}")]
        public async Task<Response<ContentDetail>> Get([FromBody] ContentDetailAnyDataTransfer Model)
        {
            await Service.AnySelectAsync(Model);
            return new Response<ContentDetail>
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