namespace Mytra.Api.Controllers
{
    using Core;
    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    public class PermissionController : ControllerBase
    {
        private readonly IPermissionService Service;
        public PermissionController(IPermissionService service)
        {
            Service = service;
        }

        [HttpPost]
        [Route("api/permission")]
        public Task<PermissionWebResponse> Create([FromBody] PermissionInsertDataTransfer Model)
        {
            Task<PermissionResponse> Data = Service.AddAsync(Model);
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