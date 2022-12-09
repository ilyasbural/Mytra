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
            UserEmailResponse userEmailResponse = await Service.InsertAsync(Model);
            return new UserEmailWebResponse { UserEmail = userEmailResponse.UserEmail };
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

        [HttpDelete]
        [Route("api/useremail")]
        public async Task<UserEmailWebResponse> Delete([FromBody] UserEmailDeleteDataTransfer Model)
        {
            UserEmailResponse userEmailResponse = await Service.DeleteAsync(Model);
            return new UserEmailWebResponse
            {


            };
        }

        [HttpGet]
        [Route("api/useremail")]
        public async Task<UserEmailWebResponse> Get([FromBody] UserEmailSelectDataTransfer Model)
        {
            UserEmailResponse userEmailResponse = await Service.SelectAsync(Model);
            return new UserEmailWebResponse
            {


            };
        }

        [HttpGet]
        [Route("api/useremail/{id}")]
        public async Task<UserEmailWebResponse> Get([FromBody] UserEmailAnyDataTransfer Model)
        {
            UserEmailResponse userEmailResponse = await Service.AnyAsync(Model);
            return new UserEmailWebResponse
            {


            };
        }
    }
}