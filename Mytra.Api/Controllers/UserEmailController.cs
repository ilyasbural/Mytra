namespace Mytra.Api.Controllers
{
    using Core;
    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    public class UserEmailController : ControllerBase
    {
        private readonly IUserEmailService Service;
        public UserEmailController(IUserEmailService service)
        {
            Service = service;
        }

        [HttpPost]
        [Route("api/useremail")]
        public async Task<UserEmailWebResponse> Create([FromBody] UserEmailInsertDataTransfer Model)
        {
            UserEmailResponse userEmailResponse = await Service.AddAsync(Model);
            return new UserEmailWebResponse
            {
                

            };
        }

        [HttpPut]
        [Route("api/useremail")]
        public async Task<UserEmailWebResponse> Update([FromBody] UserEmailUpdateDataTransfer Model)
        {
            UserEmailResponse userEmailResponse = await Service.UpdateAsync(Model);
            return new UserEmailWebResponse
            {


            };
        }
    }
}