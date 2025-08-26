namespace Mytra.Presentation.Controllers
{
	using Core;
	using Common;
	using Microsoft.AspNetCore.Mvc;

	[ApiController]
    public class CandidateAuthenticationController : ControllerBase
    {
		readonly ICandidateAuthenticationService Service;
		public CandidateAuthenticationController(ICandidateAuthenticationService service) { Service = service; }

		[HttpPost]
		[Route("api/candidateauthentication")]
		[Produces(typeof(ServiceResponse<CandidateAuthenticationResponse>))]
		public async Task<ServiceResponse<CandidateAuthenticationResponse>> Create([FromBody] CandidateAuthenticationInsert Model)
		{
			ServiceResponse<CandidateAuthenticationResponse> Response = await Service.InsertAsync(Model);
			return new ServiceResponse<CandidateAuthenticationResponse>
			{
				ResponseData = Response.ResponseData
			};
		}

		[HttpPut]
		[Route("api/candidateauthentication")]
		[Produces(typeof(ServiceResponse<CandidateAuthenticationResponse>))]
		public async Task<ServiceResponse<CandidateAuthenticationResponse>> Update([FromBody] CandidateAuthenticationUpdate Model)
		{
			ServiceResponse<CandidateAuthenticationResponse> Response = await Service.UpdateAsync(Model);
			return new ServiceResponse<CandidateAuthenticationResponse>
			{
				ResponseData = Response.ResponseData
			};
		}

		[HttpDelete]
		[Route("api/candidateauthentication")]
		[Produces(typeof(ServiceResponse<CandidateAuthenticationResponse>))]
		public async Task<ServiceResponse<CandidateAuthenticationResponse>> Delete([FromBody] CandidateAuthenticationDelete Model)
		{
			ServiceResponse<CandidateAuthenticationResponse> Response = await Service.DeleteAsync(Model);
			return new ServiceResponse<CandidateAuthenticationResponse>
			{
				ResponseData = Response.ResponseData
			};
		}

		[HttpGet]
		[Route("api/candidateauthentication")]
		[Produces(typeof(ServiceResponse<CandidateAuthenticationResponse>))]
		public async Task<ServiceResponse<CandidateAuthenticationResponse>> Get([FromQuery] CandidateAuthenticationSelect Model)
		{
			ServiceResponse<CandidateAuthenticationResponse> Response = await Service.SelectAsync(Model);
			return new ServiceResponse<CandidateAuthenticationResponse>
			{
				ResponseDataSource = Response.ResponseDataSource
			};
		}

		[HttpGet]
		[Route("api/candidateauthenticationsingle")]
		[Produces(typeof(ServiceResponse<CandidateAuthenticationResponse>))]
		public async Task<ServiceResponse<CandidateAuthenticationResponse>> GetSingle([FromQuery] CandidateAuthenticationSelectSingle Model)
		{
			ServiceResponse<CandidateAuthenticationResponse> Response = await Service.SelectSingleAsync(Model);
			return new ServiceResponse<CandidateAuthenticationResponse>
			{
				ResponseDataSource = Response.ResponseDataSource
			};
		}
	}
}