namespace Mytra.Api.Controllers
{
    using Core;
    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    public class PermissionDetailController : ControllerBase
    {
        private readonly IPermissionDetailService Service;
        public PermissionDetailController(IPermissionDetailService service)
        {
            Service = service;
        }

        [HttpPost]
        [Route("api/permissiondetail")]
        public Task<PermissionDetailWebResponse> Create([FromBody] PermissionDetailInsertDataTransfer Model)
        {
            Task<PermissionDetailResponse> Data = Service.AddAsync(Model);
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