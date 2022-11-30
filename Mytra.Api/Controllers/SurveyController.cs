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
        public Task<SurveyWebResponse> Create([FromBody] SurveyInsertDataTransfer Model)
        {
            Task<SurveyResponse> Data = Service.AddAsync(Model);
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