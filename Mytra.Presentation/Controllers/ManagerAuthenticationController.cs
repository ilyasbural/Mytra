namespace Mytra.Presentation.Controllers
{
	using Core;
	using Common;
	using AutoMapper;
	using Microsoft.AspNetCore.Mvc;

	[ApiController]
	public class ManagerAuthenticationController : ControllerBase
	{
		readonly IMapper Mapper;
		readonly IManagerAuthenticationService Service;
		public ManagerAuthenticationController(IMapper mapper, IManagerAuthenticationService service)
		{
			Mapper = mapper;
			Service = service;
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

		[HttpPost]
		[Route("api/managerauthentication")]
		[Produces(typeof(ServiceResponse<ManagerAuthentication>))]
		public async Task<ServiceResponse<ManagerAuthentication>> Create([FromBody] ManagerAuthenticationInsert Model)
		{
			DataService<ManagerAuthentication> Response = await Service.InsertAsync(Model);
			if (Response.Errors.Count > 0) return ServiceResponse<ManagerAuthentication>.FailureResponse(Response.Errors, "");
			if (!Response.Success) return ServiceResponse<ManagerAuthentication>.FailureResponse("");
			return ServiceResponse<ManagerAuthentication>.SuccessResponse(Response.Data, "");
		}

		[HttpPut]
		[Route("api/managerauthentication")]
		[Produces(typeof(ServiceResponse<ManagerAuthentication>))]
		public async Task<ServiceResponse<ManagerAuthentication>> Update([FromBody] ManagerAuthenticationUpdate Model)
		{
			DataService<ManagerAuthentication> Response = await Service.UpdateAsync(Model);
			if (Response.Errors.Count > 0) return ServiceResponse<ManagerAuthentication>.FailureResponse(Response.Errors, "");
			if (!Response.Success) return ServiceResponse<ManagerAuthentication>.FailureResponse("");
			return ServiceResponse<ManagerAuthentication>.SuccessResponse(Response.Data, "");
		}

		[HttpDelete]
		[Route("api/managerauthentication")]
		[Produces(typeof(ServiceResponse<ManagerAuthentication>))]
		public async Task<ServiceResponse<ManagerAuthentication>> Delete([FromBody] ManagerAuthenticationDelete Model)
		{
			DataService<ManagerAuthentication> Response = await Service.DeleteAsync(Model);
			if (Response.Errors.Count > 0) return ServiceResponse<ManagerAuthentication>.FailureResponse(Response.Errors, "");
			if (!Response.Success) return ServiceResponse<ManagerAuthentication>.FailureResponse("");
			return ServiceResponse<ManagerAuthentication>.SuccessResponse(Response.Data, "");
		}

		[HttpGet]
		[Route("api/managerauthentication")]
		[Produces(typeof(ServiceResponse<ManagerAuthenticationResponse>))]
		public async Task<ServiceResponse<ManagerAuthenticationResponse>> Get([FromQuery] ManagerAuthenticationSelect Model)
		{
			DataService<ManagerAuthentication> Response = await Service.SelectAsync(Model);
			return ServiceResponse<ManagerAuthenticationResponse>.SuccessResponse(Mapper.Map<List<ManagerAuthenticationResponse>>(Response.DataList), "");
		}

		[HttpGet]
		[Route("api/managerauthenticationsingle")]
		[Produces(typeof(ServiceResponse<ManagerAuthenticationResponse>))]
		public async Task<ServiceResponse<ManagerAuthenticationResponse>> GetSingle([FromQuery] ManagerAuthenticationSelectSingle Model)
		{
			DataService<ManagerAuthentication> Response = await Service.SelectSingleAsync(Model);
			return ServiceResponse<ManagerAuthenticationResponse>.SuccessResponse(Mapper.Map<List<ManagerAuthenticationResponse>>(Response.Data), "");
		}
	}
}