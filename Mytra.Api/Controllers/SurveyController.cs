namespace Mytra.Api.Controllers
{
    using Core;
    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    public class SurveyController : ControllerBase
    {
        private readonly ISurveyService Service;
        public SurveyController(ISurveyService service)
        {
            Service = service;
        }

        [HttpPost]
        [Route("api/survey")]
        public async Task<SurveyWebResponse> Create([FromBody] SurveyInsertDataTransfer Model)
        {
            SurveyResponse surveyResponse = await Service.AddAsync(Model);
            return new SurveyWebResponse
            {
                




            };
        }

        [HttpPut]
        [Route("api/survey")]
        public async Task<SurveyWebResponse> Update([FromBody] SurveyUpdateDataTransfer Model)
        {
            SurveyResponse surveyResponse = await Service.UpdateAsync(Model);
            return new SurveyWebResponse
            {





            };
        }

        [HttpDelete]
        [Route("api/survey")]
        public async Task<SurveyWebResponse> Delete([FromBody] SurveyDeleteDataTransfer Model)
        {
            SurveyResponse surveyResponse = await Service.DeleteAsync(Model);
            return new SurveyWebResponse
            {





            };
        }

        [HttpGet]
        [Route("api/survey")]
        public async Task<SurveyWebResponse> Get([FromBody] SurveySelectDataTransfer Model)
        {
            SurveyResponse surveyResponse = await Service.SelectAsync(Model);
            return new SurveyWebResponse
            {





            };
        }

        [HttpGet]
        [Route("api/survey/{id}")]
        public async Task<SurveyWebResponse> Get([FromBody] SurveyAnyDataTransfer Model)
        {
            SurveyResponse surveyResponse = await Service.AnyAsync(Model);
            return new SurveyWebResponse
            {





            };
        }
    }
}