namespace Mytra.Api.Controllers
{
    using Core;
    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    public class UserLoginController : ControllerBase
    {
        readonly IUserLoginService UserService;
        readonly IAuthenticationService AuthenticationService;
        public UserLoginController(IUserLoginService userService, IAuthenticationService authenticationService)
        {
            UserService = userService;
            AuthenticationService = authenticationService;
        }

        [HttpGet]
        [Route("api/login")]
        public async Task<Response<UserLogin>> Login([FromBody] UserLoginDataTransfer Model)
        {
            Response<UserLogin> Response = await UserService.LoginAsync(Model);
            return new Response<UserLogin>
            {
               Token = Response.Token, 
               Success = Response.Success, 
               IsValidationError = Response.IsValidationError,
               Message = Response.Message
            };
        }
    }
}