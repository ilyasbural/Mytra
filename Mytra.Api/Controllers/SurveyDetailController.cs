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
            SurveyDetailResponse surveyDetailResponse = await Service.InsertAsync(Model);
            return new SurveyDetailWebResponse { Single = surveyDetailResponse.Single };
        }

        [HttpPut]
        [Route("api/surveydetail")]
        public async Task<SurveyDetailWebResponse> Update([FromBody] SurveyDetailUpdateDataTransfer Model)
        {
            SurveyDetailResponse surveyDetailResponse = await Service.UpdateAsync(Model);
            return new SurveyDetailWebResponse { Single = surveyDetailResponse.Single };
        }

        [HttpDelete]
        [Route("api/surveydetail")]
        public async Task<SurveyDetailWebResponse> Delete([FromBody] SurveyDetailDeleteDataTransfer Model)
        {
            SurveyDetailResponse surveyDetailResponse = await Service.DeleteAsync(Model);
            return new SurveyDetailWebResponse
            {


            };
        }

        [HttpGet]
        [Route("api/surveydetail")]
        public async Task<SurveyDetailWebResponse> Get([FromBody] SurveyDetailSelectDataTransfer Model)
        {
            SurveyDetailResponse surveyDetailResponse = await Service.SelectAsync(Model);
            return new SurveyDetailWebResponse
            {


            };
        }

        [HttpGet]
        [Route("api/surveydetail/{id}")]
        public async Task<SurveyDetailWebResponse> Get([FromBody] SurveyDetailAnyDataTransfer Model)
        {
            SurveyDetailResponse surveyDetailResponse = await Service.AnyAsync(Model);
            return new SurveyDetailWebResponse
            {


            };
        }
    }
}