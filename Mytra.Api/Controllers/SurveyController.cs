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
            Response<Survey> Response = await Service.InsertAsync(Model);
            return new Response<Survey>
            {
                Data = Response.Data,
                Message = Response.Message,
                Success = Response.Success,
                IsValidationError = Response.IsValidationError
            };
        }

        [HttpPut]
        [Route("api/survey")]
        public async Task<Response<Survey>> Update([FromBody] SurveyUpdateDataTransfer Model)
        {
            Response<Survey> Response = await Service.UpdateAsync(Model);
            return new Response<Survey>
            {
                Data = Response.Data,
                Message = Response.Message,
                Success = Response.Success,
                IsValidationError = Response.IsValidationError
            };
        }

        [HttpDelete]
        [Route("api/survey")]
        public async Task<Response<Survey>> Delete([FromBody] SurveyDeleteDataTransfer Model)
        {
            Response<Survey> Response = await Service.DeleteAsync(Model);
            return new Response<Survey>
            {
                Data = Response.Data,
                Message = Response.Message,
                Success = Response.Success,
                IsValidationError = Response.IsValidationError
            };
        }

        [HttpGet]
        [Route("api/survey")]
        public async Task<Response<Survey>> Get([FromBody] SurveySelectDataTransfer Model)
        {
            Response<Survey> Response = await Service.SelectAsync(Model);
            return new Response<Survey>
            {
                Collection = Response.Collection,
                Message = Response.Message,
                Success = Response.Success,
                IsValidationError = Response.IsValidationError
            };
        }

        [HttpGet]
        [Route("api/survey/{id}")]
        public async Task<Response<Survey>> Get([FromBody] SurveyAnyDataTransfer Model)
        {
            Response<Survey> Response = await Service.AnySelectAsync(Model);
            return new Response<Survey>
            {
                Collection = Response.Collection,
                Message = Response.Message,
                Success = Response.Success,
                IsValidationError = Response.IsValidationError
            };
        }
    }
}