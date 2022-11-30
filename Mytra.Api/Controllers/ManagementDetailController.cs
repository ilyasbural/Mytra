namespace Mytra.Api.Controllers
{
    using Core;
    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    public class ManagementDetailController : ControllerBase
    {
        private readonly IManagementDetailService Service;
        public ManagementDetailController(IManagementDetailService service)
        {
            Service = service;
        }

        [HttpPost]
        [Route("api/managementdetail")]
        public Task<ManagementDetailWebResponse> Create([FromBody] ManagementDetailInsertDataTransfer Model)
        {
            Task<ManagementDetailResponse> Data = Service.AddAsync(Model);
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