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
        public Task<SurveyDetailWebResponse> Create([FromBody] SurveyDetailInsertDataTransfer Model)
        {
            Task<SurveyDetailResponse> Data = Service.AddAsync(Model);
            //AnnounceResult Result = Service.AddAsync(Model);
            //return new AnnounceResponse
            //{
            //    Id = Result.Id,
            //    Company = Result.Company,
            //    Occupation = Result.Occupation,
            //    Title = Result.Title,
            //    AnnounceDate = Result.AnnounceDate,
            //    CreatedByUser = Result.CreatedByUser,
            //    UpdatedByUser = Result.UpdatedByUser,
            //    RegisterDate = Result.RegisterDate,
            //    UpdateDate = Result.UpdateDate
            //};
            return Create(Model);
        }
    }
}