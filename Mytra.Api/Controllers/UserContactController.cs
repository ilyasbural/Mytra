namespace Mytra.Api.Controllers
{
    using Core;
    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    public class UserContactController : ControllerBase
    {
        private readonly IUserContactService Service;
        public UserContactController(IUserContactService service)
        {
            Service = service;
        }

        [HttpPost]
        [Route("api/usercontact")]
        public Task<UserContactWebResponse> Create([FromBody] UserContactInsertDataTransfer Model)
        {
            Task<UserContactResponse> Data = Service.AddAsync(Model);
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