namespace Mytra.Business
{
    using Core;
    using AutoMapper;
    using FluentValidation;

    public class UserLoginManager : IUserLoginService
    {
        readonly IUnitOfWork UnitOfWork;
        readonly IValidator<User> Validator;
        readonly IAuthenticationService AuthenticationService;
        

        public UserLoginManager(IUnitOfWork unitOfWork, IValidator<User> validator, IAuthenticationService authenticationService)
        {
            UnitOfWork = unitOfWork;
            Validator = validator;
            AuthenticationService = authenticationService;
        }

        public async Task<Response<UserLogin>> LoginAsync(UserLoginDataTransfer Model)
        {
            AccessToken Token = new AccessToken();
            List<User> Collection = await UnitOfWork.User.SelectAsync(x => x.Email == Model.Email && x.Password == Model.Password);
            if (Collection.Count > 0) Token = await AuthenticationService.CreateAccessToken(Model.Email, Model.Password);

            return new Response<UserLogin>
            {
                Token = Token.Token, 
                Success = 1, 
                IsValidationError = false, 
                Message = "Success"
            };
        }
    }
}