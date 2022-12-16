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
        public async Task<SurveyWebResponse> Create([FromBody] SurveyInsertDataTransfer Model)
        {
            SurveyResponse surveyResponse = await Service.InsertAsync(Model);
            return new SurveyWebResponse 
            { 
                Single = surveyResponse.Single, 
                Success = surveyResponse.Success
            };
        }

        [HttpPut]
        [Route("api/survey")]
        public async Task<SurveyWebResponse> Update([FromBody] SurveyUpdateDataTransfer Model)
        {
            SurveyResponse surveyResponse = await Service.UpdateAsync(Model);
            return new SurveyWebResponse
            {
                Single = surveyResponse.Single,
                Success = surveyResponse.Success
            };
        }

        [HttpDelete]
        [Route("api/survey")]
        public async Task<SurveyWebResponse> Delete([FromBody] SurveyDeleteDataTransfer Model)
        {
            SurveyResponse surveyResponse = await Service.DeleteAsync(Model);
            return new SurveyWebResponse
            {
                Success = surveyResponse.Success
            };
        }

        [HttpGet]
        [Route("api/survey")]
        public async Task<SurveyWebResponse> Get([FromBody] SurveySelectDataTransfer Model)
        {
            SurveyResponse surveyResponse = await Service.SelectAsync(Model);
            return new SurveyWebResponse
            {
                List = surveyResponse.List, 
                Success = surveyResponse.Success, 
                Message = surveyResponse.Message
            };
        }

        [HttpGet]
        [Route("api/survey/{id}")]
        public async Task<SurveyWebResponse> Get([FromBody] SurveyAnyDataTransfer Model)
        {
            SurveyResponse surveyResponse = await Service.AnyAsync(Model);
            return new SurveyWebResponse
            {
                List = surveyResponse.List,
                Success = surveyResponse.Success,
                Message = surveyResponse.Message
            };
        }
    }
}