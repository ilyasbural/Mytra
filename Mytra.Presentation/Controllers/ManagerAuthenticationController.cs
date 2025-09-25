namespace Mytra.Presentation.Controllers
{
	using Core;
	using Utilize;
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
		[Route("api/managerauthentication")]
		[Produces(typeof(ServiceResponse<ManagerAuthenticationResponse>))]
		public async Task<ServiceResponse<ManagerAuthenticationResponse>> Create([FromBody] ManagerAuthenticationInsert Model)
		{
			DataService<ManagerAuthentication> Response = await Service.InsertAsync(Model);
			if (Response.Errors.Count > 0) return ServiceResponse<ManagerAuthenticationResponse>.FailureResponse(Response.Errors, "");
			if (!Response.Success) return ServiceResponse<ManagerAuthenticationResponse>.FailureResponse("");
			return ServiceResponse<ManagerAuthenticationResponse>.SuccessResponse(Mapper.Map<ManagerAuthenticationResponse>(Response.Data), "");
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
		[Route("api/managerauthentication/{id}")]
		[Produces(typeof(ServiceResponse<ManagerAuthentication>))]
		public async Task<ServiceResponse<ManagerAuthentication>> Delete(Guid Id)
		{
			DataService<ManagerAuthentication> Response = await Service.DeleteAsync(Id);
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
			return ServiceResponse<ManagerAuthenticationResponse>.SuccessResponse(Mapper.Map<ManagerAuthenticationResponse>(Response.Data), "");
		}
	}
}