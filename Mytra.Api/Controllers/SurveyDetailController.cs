namespace Mytra.Api.Controllers
{
    using Core;
    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    public class SurveyDetailController : ControllerBase
    {
        readonly ISurveyDetailService Service;
        public SurveyDetailController(ISurveyDetailService service)
        {
            Service = service;
        }

        [HttpPost]
        [Route("api/surveydetail")]
        public async Task<Response<SurveyDetail>> Create([FromBody] SurveyDetailInsertDataTransfer Model)
        {
            await Service.InsertAsync(Model);
            return new Response<SurveyDetail>
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
        [Route("api/surveydetail")]
        public async Task<Response<SurveyDetail>> Update([FromBody] SurveyDetailUpdateDataTransfer Model)
        {
            await Service.UpdateAsync(Model);
            return new Response<SurveyDetail>
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
        [Route("api/surveydetail")]
        public async Task<Response<SurveyDetail>> Delete([FromBody] SurveyDetailDeleteDataTransfer Model)
        {
            await Service.DeleteAsync(Model);
            return new Response<SurveyDetail>
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
        [Route("api/surveydetail")]
        public async Task<Response<SurveyDetail>> Get([FromBody] SurveyDetailSelectDataTransfer Model)
        {
            await Service.SelectAsync(Model);
            return new Response<SurveyDetail>
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
        [Route("api/surveydetail/{id}")]
        public async Task<Response<SurveyDetail>> Get([FromBody] SurveyDetailAnyDataTransfer Model)
        {
            await Service.AnySelectAsync(Model);
            return new Response<SurveyDetail>
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