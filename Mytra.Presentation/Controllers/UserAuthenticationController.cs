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

		//[HttpPost]
		//[Route("api/userauthentication")]
		//[Produces(typeof(ServiceResponse<UserAuthenticationResponse>))]
		//public async Task<ServiceResponse<UserAuthenticationResponse>> Create([FromBody] UserAuthenticationInsert Model)
		//{
		//	ServiceResponse<UserAuthenticationResponse> Response = await Service.InsertAsync(Model);
		//	return new ServiceResponse<UserAuthenticationResponse>
		//	{
		//		Success = Response.Success,
		//		ResponseData = Response.ResponseData
		//	};
		//}

		//[HttpPut]
		//[Route("api/userauthentication")]
		//[Produces(typeof(ServiceResponse<UserAuthenticationResponse>))]
		//public async Task<ServiceResponse<UserAuthenticationResponse>> Update([FromBody] UserAuthenticationUpdate Model)
		//{
		//	ServiceResponse<UserAuthenticationResponse> Response = await Service.UpdateAsync(Model);
		//	return new ServiceResponse<UserAuthenticationResponse>
		//	{
		//		Success = Response.Success,
		//		ResponseData = Response.ResponseData
		//	};
		//}

		//[HttpDelete]
		//[Route("api/userauthentication")]
		//[Produces(typeof(ServiceResponse<UserAuthenticationResponse>))]
		//public async Task<ServiceResponse<UserAuthenticationResponse>> Delete([FromBody] UserAuthenticationDelete Model)
		//{
		//	ServiceResponse<UserAuthenticationResponse> Response = await Service.DeleteAsync(Model);
		//	return new ServiceResponse<UserAuthenticationResponse>
		//	{
		//		Success = Response.Success,
		//		ResponseData = Response.ResponseData
		//	};
		//}

		[HttpGet]
		[Route("api/userauthentication")]
		[Produces(typeof(ServiceResponse<UserAuthentication>))]
		public async Task<ServiceResponse<UserAuthentication>> Get([FromQuery] UserAuthenticationSelect Model)
		{
			DataService<UserAuthentication> Response = await Service.SelectAsync(Model);
			return ServiceResponse<UserAuthentication>.SuccessResponse(Response.DataList, "userauthentications list added");
		}

		//[HttpGet]
		//[Route("api/userauthenticationsingle")]
		//[Produces(typeof(ServiceResponse<UserAuthenticationResponse>))]
		//public async Task<ServiceResponse<UserAuthenticationResponse>> GetSingle([FromQuery] UserAuthenticationSelectSingle Model)
		//{
		//	ServiceResponse<UserAuthenticationResponse> Response = await Service.SelectSingleAsync(Model);
		//	return new ServiceResponse<UserAuthenticationResponse>
		//	{
		//		ResponseDataSource = Response.ResponseDataSource
		//	};
		//}
	}
}