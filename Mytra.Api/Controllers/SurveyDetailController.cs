namespace Mytra.Api.Controllers
{
    using Core;
    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    public class SurveyDetailController : ControllerBase
    {
        private readonly ISurveyDetailService Service;
        public SurveyDetailController(ISurveyDetailService service)
        {
            Service = service;
        }

        [HttpPost]
        [Route("api/surveydetail")]
        public async Task<SurveyDetailWebResponse> Create([FromBody] SurveyDetailInsertDataTransfer Model)
        {
            SurveyDetailResponse surveyDetailResponse = await Service.AddAsync(Model);
            return new SurveyDetailWebResponse
            {
               

            };
        }

        [HttpPut]
        [Route("api/surveydetail")]
        public async Task<UserContactWebResponse> Update([FromBody] SurveyDetailUpdateDataTransfer Model)
        {
            SurveyDetailResponse surveyDetailResponse = await Service.UpdateAsync(Model);
            return new UserContactWebResponse
            {


            };
        }
    }
}