namespace Mytra.Presentation.Controllers
{
	using AutoMapper;
	using Common;
	using Core;
	using Microsoft.AspNetCore.Mvc;
	using Microsoft.Extensions.Configuration;
	using Microsoft.IdentityModel.Tokens;
	using System.IdentityModel.Tokens.Jwt;
	using System.Security.Claims;
	using System.Text;

	[ApiController]
	public class CandidateLoginController : ControllerBase
	{
		readonly IMapper Mapper;
		readonly IConfiguration Configuration;
		readonly ICandidateLoginService LoginService;
		readonly ICandidateAuthenticationService AuthenticationService;

		public CandidateLoginController(IConfiguration configuration, ICandidateLoginService loginService, ICandidateAuthenticationService authenticationService)
		{
			Configuration = configuration;  
			LoginService = loginService;
			AuthenticationService = authenticationService;
		}

		[HttpGet]
		[Route("api/candidatelogin")]
		[Produces(typeof(ServiceResponse<Candidate>))]
		public async Task<ServiceResponse<Candidate>> GetSingle([FromQuery] CandidateLogin Model)
		{
			DataService<Candidate> Response = await LoginService.LoginAsync(Model);
			
			List<Claim> Claims = new List<Claim>()
			{
				new Claim("Id", Response.Data.Id.ToString()),
				new Claim("Email", Response.Data.Email.ToString()),
				new Claim("Password", Response.Data.Password.ToString()),
				new Claim("Role", "Candidate")
			};

			JwtSecurityToken JsonSecurityToken = new JwtSecurityToken(
				issuer: Configuration["JwtTokenOptions:Issuer"],
				audience: Configuration["JwtTokenOptions:Audience"],
				claims: Claims,
				notBefore: DateTime.Now,
				expires: DateTime.Now.AddMinutes(30),
				signingCredentials: new SigningCredentials(new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Configuration["JwtTokenOptions:Key"]!)), SecurityAlgorithms.HmacSha256));
			
			Response.Data.Password = String.Empty;
			String JsonToken = new JwtSecurityTokenHandler().WriteToken(JsonSecurityToken);
			String RefreshToken = new RefreshTokenGenerator().GenerateRefreshToken();

			DataService<CandidateAuthentication> Auth = await AuthenticationService.InsertAsync(new CandidateAuthenticationInsert
			{
				CandidateId = Response.Data.Id,
				RefreshToken = RefreshToken,
				RefreshTokenExpireTime = DateTime.Now.AddDays(1)
			});

			return ServiceResponse<Candidate>.TokenResponse(Response.Data, JsonToken, RefreshToken);
		}
	}
}