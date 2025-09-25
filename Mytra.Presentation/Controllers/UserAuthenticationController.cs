namespace Mytra.Presentation.Controllers
{
	using Core;
	using Utilize;
	using AutoMapper;
	using Microsoft.AspNetCore.Mvc;

	[ApiController]
	public class UserAuthenticationController : ControllerBase
	{
		readonly IMapper Mapper;
		readonly IUserAuthenticationService Service;
		public UserAuthenticationController(IMapper mapper, IUserAuthenticationService service)
		{
			Mapper = mapper;
			Service = service;
		}

		[HttpPost]
		[Route("api/userauthentication")]
		[Produces(typeof(ServiceResponse<UserAuthenticationResponse>))]
		public async Task<ServiceResponse<UserAuthenticationResponse>> Create([FromBody] UserAuthenticationInsert Model)
		{
			DataService<UserAuthentication> Response = await Service.InsertAsync(Model);
			if (Response.Errors.Count > 0) return ServiceResponse<UserAuthenticationResponse>.FailureResponse(Response.Errors, "");
			if (!Response.Success) return ServiceResponse<UserAuthenticationResponse>.FailureResponse("");
			return ServiceResponse<UserAuthenticationResponse>.SuccessResponse(Mapper.Map<UserAuthenticationResponse>(Response.Data), "");
		}

		[HttpPut]
		[Route("api/userauthentication")]
		[Produces(typeof(ServiceResponse<UserAuthentication>))]
		public async Task<ServiceResponse<UserAuthentication>> Update([FromBody] UserAuthenticationUpdate Model)
		{
			DataService<UserAuthentication> Response = await Service.UpdateAsync(Model);
			if (Response.Errors.Count > 0) return ServiceResponse<UserAuthentication>.FailureResponse(Response.Errors, "");
			if (!Response.Success) return ServiceResponse<UserAuthentication>.FailureResponse("");
			return ServiceResponse<UserAuthentication>.SuccessResponse(Response.Data, "");
		}

		[HttpDelete]
		[Route("api/userauthentication/{id}")]
		[Produces(typeof(ServiceResponse<UserAuthentication>))]
		public async Task<ServiceResponse<UserAuthentication>> Delete(Guid Id)
		{
			DataService<UserAuthentication> Response = await Service.DeleteAsync(Id);
			if (Response.Errors.Count > 0) return ServiceResponse<UserAuthentication>.FailureResponse(Response.Errors, "");
			if (!Response.Success) return ServiceResponse<UserAuthentication>.FailureResponse("");
			return ServiceResponse<UserAuthentication>.SuccessResponse(Response.Data, "");
		}

		[HttpGet]
		[Route("api/userauthentication")]
		[Produces(typeof(ServiceResponse<UserAuthenticationResponse>))]
		public async Task<ServiceResponse<UserAuthenticationResponse>> Get([FromQuery] UserAuthenticationSelect Model)
		{
			DataService<UserAuthentication> Response = await Service.SelectAsync(Model);
			return ServiceResponse<UserAuthenticationResponse>.SuccessResponse(Mapper.Map<List<UserAuthenticationResponse>>(Response.DataList), "");
		}

		[HttpGet]
		[Route("api/userauthenticationsingle")]
		[Produces(typeof(ServiceResponse<UserAuthenticationResponse>))]
		public async Task<ServiceResponse<UserAuthenticationResponse>> GetSingle([FromQuery] UserAuthenticationSelectSingle Model)
		{
			DataService<UserAuthentication> Response = await Service.SelectSingleAsync(Model);
			return ServiceResponse<UserAuthenticationResponse>.SuccessResponse(Mapper.Map<UserAuthenticationResponse>(Response.Data), "");
		}
	}
}