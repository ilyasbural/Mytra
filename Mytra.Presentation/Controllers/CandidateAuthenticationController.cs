namespace Mytra.Presentation.Controllers
{
	using Core;
	using Utilize;
	using AutoMapper;
	using Microsoft.AspNetCore.Mvc;

	[ApiController]
    public class CandidateAuthenticationController : ControllerBase
    {
		readonly IMapper Mapper;
		readonly ICandidateAuthenticationService Service;
		public CandidateAuthenticationController(IMapper mapper, ICandidateAuthenticationService service)
		{
			Mapper = mapper;
			Service = service;
		}

		[HttpPost]
		[Route("api/candidateauthentication")]
		[Produces(typeof(ServiceResponse<CandidateAuthenticationResponse>))]
		public async Task<ServiceResponse<CandidateAuthenticationResponse>> Create([FromBody] CandidateAuthenticationInsert Model)
		{
			DataService<CandidateAuthentication> Response = await Service.InsertAsync(Model);
			if (Response.Errors.Count > 0) return ServiceResponse<CandidateAuthenticationResponse>.FailureResponse(Response.Errors, "");
			if (!Response.Success) return ServiceResponse<CandidateAuthenticationResponse>.FailureResponse("");
			return ServiceResponse<CandidateAuthenticationResponse>.SuccessResponse(Mapper.Map<CandidateAuthenticationResponse>(Response.Data), "");
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
		[Route("api/candidateauthentication/{id}")]
		[Produces(typeof(ServiceResponse<CandidateAuthentication>))]
		public async Task<ServiceResponse<CandidateAuthentication>> Delete(Guid Id)
		{
			DataService<CandidateAuthentication> Response = await Service.DeleteAsync(Id);
			if (Response.Errors.Count > 0) return ServiceResponse<CandidateAuthentication>.FailureResponse(Response.Errors, "");
			if (!Response.Success) return ServiceResponse<CandidateAuthentication>.FailureResponse("");
			return ServiceResponse<CandidateAuthentication>.SuccessResponse(Response.Data, "");
		}

		[HttpGet]
		[Route("api/candidateauthentication")]
		[Produces(typeof(ServiceResponse<CandidateAuthenticationResponse>))]
		public async Task<ServiceResponse<CandidateAuthenticationResponse>> Get([FromQuery] CandidateAuthenticationSelect Model)
		{
			DataService<CandidateAuthentication> Response = await Service.SelectAsync(Model);
			return ServiceResponse<CandidateAuthenticationResponse>.SuccessResponse(Mapper.Map<List<CandidateAuthenticationResponse>>(Response.DataList), "");
		}

		[HttpGet]
		[Route("api/candidateauthenticationsingle")]
		[Produces(typeof(ServiceResponse<CandidateAuthenticationResponse>))]
		public async Task<ServiceResponse<CandidateAuthenticationResponse>> GetSingle([FromQuery] CandidateAuthenticationSelectSingle Model)
		{
			DataService<CandidateAuthentication> Response = await Service.SelectSingleAsync(Model);
			return ServiceResponse<CandidateAuthenticationResponse>.SuccessResponse(Mapper.Map<CandidateAuthenticationResponse>(Response.Data), "");
		}
	}
}