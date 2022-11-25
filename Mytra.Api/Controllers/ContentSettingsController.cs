using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Mytra.Core;

namespace Mytra.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContentSettingsController : ControllerBase
    {
        private readonly IContentSettingsService Service;
        public ContentSettingsController(IContentSettingsService service)
        {
            Service = service;
        }

        //[HttpPost]
        //public Task<IActionResult> Create([FromBody] AnnounceDataTransfer Model)
        //{
        //    Task<AnnounceDataTransfer> Data = Service.AddAsync(Model);
        //    //AnnounceResult Result = Service.AddAsync(Model);
        //    //return new AnnounceResponse
        //    //{
        //    //    Id = Result.Id,
        //    //    Company = Result.Company,
        //    //    Occupation = Result.Occupation,
        //    //    Title = Result.Title,
        //    //    AnnounceDate = Result.AnnounceDate,
        //    //    CreatedByUser = Result.CreatedByUser,
        //    //    UpdatedByUser = Result.UpdatedByUser,
        //    //    RegisterDate = Result.RegisterDate,
        //    //    UpdateDate = Result.UpdateDate
        //    //};
        //    return Create(Model);
        //}
    }
}