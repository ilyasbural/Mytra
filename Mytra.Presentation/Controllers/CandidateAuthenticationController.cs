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
		[Produces(typeof(ServiceResponse<CandidateAuthentication>))]
		public async Task<ServiceResponse<CandidateAuthentication>> Create([FromBody] CandidateAuthenticationInsert Model)
		{
			DataService<CandidateAuthentication> Response = await Service.InsertAsync(Model);
			if (Response.Errors.Count > 0) return ServiceResponse<CandidateAuthentication>.FailureResponse(Response.Errors, "");
			if (!Response.Success) return ServiceResponse<CandidateAuthentication>.FailureResponse("");
			return ServiceResponse<CandidateAuthentication>.SuccessResponse(Response.Data, "");
		}

		[HttpPut]
		[Route("api/candidateauthentication")]
		[Produces(typeof(ServiceResponse<CandidateAuthentication>))]
		public async Task<ServiceResponse<CandidateAuthentication>> Update([FromBody] CandidateAuthenticationUpdate Model)
		{
			DataService<CandidateAuthentication> Response = await Service.UpdateAsync(Model);
			if (Response.Errors.Count > 0) return ServiceResponse<CandidateAuthentication>.FailureResponse(Response.Errors, "");
			if (!Response.Success) return ServiceResponse<CandidateAuthentication>.FailureResponse("");
			return ServiceResponse<CandidateAuthentication>.SuccessResponse(Response.Data, "");
		}

		[HttpDelete]
		[Route("api/candidateauthentication")]
		[Produces(typeof(ServiceResponse<CandidateAuthentication>))]
		public async Task<ServiceResponse<CandidateAuthentication>> Delete([FromBody] CandidateAuthenticationDelete Model)
		{
			DataService<CandidateAuthentication> Response = await Service.DeleteAsync(Model);
			if (Response.Errors.Count > 0) return ServiceResponse<CandidateAuthentication>.FailureResponse(Response.Errors, "");
			if (!Response.Success) return ServiceResponse<CandidateAuthentication>.FailureResponse("");
			return ServiceResponse<CandidateAuthentication>.SuccessResponse(Response.Data, "");
		}

		[HttpGet]
		[Route("api/candidateauthentication")]
		[Produces(typeof(ServiceResponse<CandidateAuthentication>))]
		public async Task<ServiceResponse<CandidateAuthentication>> Get([FromQuery] CandidateAuthenticationSelect Model)
		{
			DataService<CandidateAuthentication> Response = await Service.SelectAsync(Model);
			return ServiceResponse<CandidateAuthentication>.SuccessResponse(Response.DataList, "");
		}

		[HttpGet]
		[Route("api/candidateauthenticationsingle")]
		[Produces(typeof(ServiceResponse<CandidateAuthentication>))]
		public async Task<ServiceResponse<CandidateAuthentication>> GetSingle([FromQuery] CandidateAuthenticationSelectSingle Model)
		{
			DataService<CandidateAuthentication> Response = await Service.SelectSingleAsync(Model);
			return ServiceResponse<CandidateAuthentication>.SuccessResponse(Response.Data, "");
		}
	}
}