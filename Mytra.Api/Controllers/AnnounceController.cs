namespace Mytra.Api.Controllers
{
    using Core;
    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    public class AnnounceController : ControllerBase
    {
        private readonly IAnnounceService Service;
        public AnnounceController(IAnnounceService service)
        {
            Service = service;
        }

        [HttpPost]
        [Route("api/announce")]
        public Task<AnnounceWebResponse> Create([FromBody] AnnounceInsertDataTransfer Model)
        {
            Task<AnnounceResponse> Data = Service.AddAsync(Model);
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