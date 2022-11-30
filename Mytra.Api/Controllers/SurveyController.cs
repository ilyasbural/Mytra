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
    }
}