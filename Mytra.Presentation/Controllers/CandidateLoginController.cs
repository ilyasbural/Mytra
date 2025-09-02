namespace Mytra.Presentation.Controllers
{
	using Core;
	using Common;
	using System.Text;
	using System.Security.Claims;
	using System.IdentityModel.Tokens.Jwt;
	using Microsoft.AspNetCore.Mvc;
	using Microsoft.IdentityModel.Tokens;
	using Microsoft.Extensions.Configuration;

	[ApiController]
	public class CandidateLoginController : ControllerBase
	{
		readonly IConfiguration Configuration;
		readonly ICandidateLoginService Service;
		public CandidateLoginController(IConfiguration configuration, ICandidateLoginService service) { Configuration = configuration;  Service = service; }

		[HttpGet]
		[Route("api/candidatelogin")]
		[Produces(typeof(ServiceResponse<Candidate>))]
		public async Task<ServiceResponse<Candidate>> GetSingle([FromQuery] CandidateLogin Model)
		{
			DataService<Candidate> Response = await Service.LoginAsync(Model);

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
				signingCredentials: new SigningCredentials(new SymmetricSecurityKey(Encoding.UTF8.GetBytes("ThisIsASecretKeydfgdfgdfgdgdfgfdgfdgdfgdfgdfgfdrleojeırjeırjfıeorjeıjerdfgdflıgdflıgdlfıgdl")), SecurityAlgorithms.HmacSha256));

			Response.Data.Password = String.Empty;
			String JsonToken = new JwtSecurityTokenHandler().WriteToken(JsonSecurityToken);
			return ServiceResponse<Candidate>.TokenResponse(Response.Data, JsonToken, "");
		}
	}
}