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

		public CandidateLoginController(IMapper mapper, IConfiguration configuration, ICandidateLoginService loginService, ICandidateAuthenticationService authenticationService)
		{
			Mapper = mapper;
			Configuration = configuration;  
			LoginService = loginService;
			AuthenticationService = authenticationService;
		}

		[HttpPost]
		[Route("api/candidate")]
		[Produces(typeof(ServiceResponse<CandidateResponse>))]
		public async Task<ServiceResponse<CandidateResponse>> Create([FromBody] CandidateInsert Model)
		{
			DataService<Candidate> Response = await Service.InsertAsync(Model);
			if (Response.Errors.Count > 0) return ServiceResponse<CandidateResponse>.FailureResponse(Response.Errors, "");
			if (!Response.Success) return ServiceResponse<CandidateResponse>.FailureResponse("");
			return ServiceResponse<CandidateResponse>.SuccessResponse(Mapper.Map<List<CandidateResponse>>(Response.Data), "");
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