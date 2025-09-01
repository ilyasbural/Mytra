namespace Mytra.Presentation.Controllers
{
	using Core;
	using Common;
	using Microsoft.AspNetCore.Mvc;

	[ApiController]
	public class UserAuthenticationController : ControllerBase
	{
		readonly IUserAuthenticationService Service;
		public UserAuthenticationController(IUserAuthenticationService service) { Service = service; }

		[HttpPost]
		[Route("api/userauthentication")]
		[Produces(typeof(ServiceResponse<UserAuthentication>))]
		public async Task<ServiceResponse<UserAuthentication>> Create([FromBody] UserAuthenticationInsert Model)
		{
			DataService<UserAuthentication> Response = await Service.InsertAsync(Model);
			if (Response.Errors.Count > 0) return ServiceResponse<UserAuthentication>.FailureResponse(Response.Errors, "");
			if (!Response.Success) return ServiceResponse<UserAuthentication>.FailureResponse("");
			return ServiceResponse<UserAuthentication>.SuccessResponse(Response.Data, "");
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
		[Route("api/userauthentication")]
		[Produces(typeof(ServiceResponse<UserAuthentication>))]
		public async Task<ServiceResponse<UserAuthentication>> Delete([FromBody] UserAuthenticationDelete Model)
		{
			DataService<UserAuthentication> Response = await Service.DeleteAsync(Model);
			if (Response.Errors.Count > 0) return ServiceResponse<UserAuthentication>.FailureResponse(Response.Errors, "");
			if (!Response.Success) return ServiceResponse<UserAuthentication>.FailureResponse("");
			return ServiceResponse<UserAuthentication>.SuccessResponse(Response.Data, "");
		}

		[HttpGet]
		[Route("api/userauthentication")]
		[Produces(typeof(ServiceResponse<UserAuthentication>))]
		public async Task<ServiceResponse<UserAuthentication>> Get([FromQuery] UserAuthenticationSelect Model)
		{
			DataService<UserAuthentication> Response = await Service.SelectAsync(Model);
			return ServiceResponse<UserAuthentication>.SuccessResponse(Response.DataList, "");
		}

		[HttpGet]
		[Route("api/userauthenticationsingle")]
		[Produces(typeof(ServiceResponse<UserAuthentication>))]
		public async Task<ServiceResponse<UserAuthentication>> GetSingle([FromQuery] UserAuthenticationSelectSingle Model)
		{
			DataService<UserAuthentication> Response = await Service.SelectSingleAsync(Model);
			return ServiceResponse<UserAuthentication>.SuccessResponse(Response.Data, "");
		}
	}
}