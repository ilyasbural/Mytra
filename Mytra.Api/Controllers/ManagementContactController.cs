namespace Mytra.Api.Controllers
{
    using Core;
    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    public class ManagementContactController : ControllerBase
    {
        private readonly IManagementContactService Service;
        public ManagementContactController(IManagementContactService service)
        {
            Service = service;
        }

        [HttpPost]
        [Route("api/managementcontact")]
        public Task<ManagementContactWebResponse> Create([FromBody] ManagementContactInsertDataTransfer Model)
        {
            Task<ManagementContactResponse> Data = Service.AddAsync(Model);
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