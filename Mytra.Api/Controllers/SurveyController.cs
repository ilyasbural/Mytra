namespace Mytra.Api.Controllers
{
    using Core;
    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    public class SurveyController : ControllerBase
    {
        readonly ISurveyService Service;
        public SurveyController(ISurveyService service)
        {
            Service = service;
        }

        [HttpPost]
        [Route("api/survey")]
        public async Task<Response<Survey>> Create([FromBody] SurveyInsertDataTransfer Model)
        {
            await Service.InsertAsync(Model);
            return new Response<Survey>
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
        [Route("api/survey")]
        public async Task<Response<Survey>> Update([FromBody] SurveyUpdateDataTransfer Model)
        {
            await Service.UpdateAsync(Model);
            return new Response<Survey>
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
        [Route("api/survey")]
        public async Task<Response<Survey>> Delete([FromBody] SurveyDeleteDataTransfer Model)
        {
            await Service.DeleteAsync(Model);
            return new Response<Survey>
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
        [Route("api/survey")]
        public async Task<Response<Survey>> Get([FromBody] SurveySelectDataTransfer Model)
        {
            await Service.SelectAsync(Model);
            return new Response<Survey>
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
        [Route("api/survey/{id}")]
        public async Task<Response<Survey>> Get([FromBody] SurveyAnyDataTransfer Model)
        {
            await Service.AnySelectAsync(Model);
            return new Response<Survey>
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