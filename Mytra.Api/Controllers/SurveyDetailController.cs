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
            Response<SurveyDetail> Response = await Service.InsertAsync(Model);
            return new Response<SurveyDetail>
            {
                Data = Response.Data,
                Message = Response.Message,
                Success = Response.Success,
                IsValidationError = Response.IsValidationError
            };
        }

        [HttpPut]
        [Route("api/surveydetail")]
        public async Task<Response<SurveyDetail>> Update([FromBody] SurveyDetailUpdateDataTransfer Model)
        {
            Response<SurveyDetail> Response = await Service.UpdateAsync(Model);
            return new Response<SurveyDetail>
            {
                Data = Response.Data,
                Message = Response.Message,
                Success = Response.Success,
                IsValidationError = Response.IsValidationError
            };
        }

        [HttpDelete]
        [Route("api/surveydetail")]
        public async Task<Response<SurveyDetail>> Delete([FromBody] SurveyDetailDeleteDataTransfer Model)
        {
            Response<SurveyDetail> Response = await Service.DeleteAsync(Model);
            return new Response<SurveyDetail>
            {
                Data = Response.Data,
                Message = Response.Message,
                Success = Response.Success,
                IsValidationError = Response.IsValidationError
            };
        }

        [HttpGet]
        [Route("api/surveydetail")]
        public async Task<Response<SurveyDetail>> Get([FromBody] SurveyDetailSelectDataTransfer Model)
        {
            Response<SurveyDetail> Response = await Service.SelectAsync(Model);
            return new Response<SurveyDetail>
            {
                Collection = Response.Collection,
                Message = Response.Message,
                Success = Response.Success,
                IsValidationError = Response.IsValidationError
            };
        }

        [HttpGet]
        [Route("api/surveydetail/{id}")]
        public async Task<Response<SurveyDetail>> Get([FromBody] SurveyDetailAnyDataTransfer Model)
        {
            Response<SurveyDetail> Response = await Service.AnySelectAsync(Model);
            return new Response<SurveyDetail>
            {
                Collection = Response.Collection,
                Message = Response.Message,
                Success = Response.Success,
                IsValidationError = Response.IsValidationError
            };
        }
    }
}