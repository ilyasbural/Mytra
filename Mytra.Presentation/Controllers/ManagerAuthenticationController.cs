namespace Mytra.Presentation.Controllers
{
	using Core;
	using Common;
	using Microsoft.AspNetCore.Mvc;

	[ApiController]
	public class ManagerAuthenticationController : ControllerBase
	{
		readonly IManagerAuthenticationService Service;
		public ManagerAuthenticationController(IManagerAuthenticationService service) { Service = service; }

		//[HttpPost]
		//[Route("api/managerauthentication")]
		//[Produces(typeof(ServiceResponse<ManagerAuthenticationResponse>))]
		//public async Task<ServiceResponse<ManagerAuthenticationResponse>> Create([FromBody] ManagerAuthenticationInsert Model)
		//{
		//	ServiceResponse<ManagerAuthenticationResponse> Response = await Service.InsertAsync(Model);
		//	return new ServiceResponse<ManagerAuthenticationResponse>
		//	{
		//		Success = Response.Success,
		//		ResponseData = Response.ResponseData
		//	};
		//}

		//[HttpPut]
		//[Route("api/managerauthentication")]
		//[Produces(typeof(ServiceResponse<ManagerAuthenticationResponse>))]
		//public async Task<ServiceResponse<ManagerAuthenticationResponse>> Update([FromBody] ManagerAuthenticationUpdate Model)
		//{
		//	ServiceResponse<ManagerAuthenticationResponse> Response = await Service.UpdateAsync(Model);
		//	return new ServiceResponse<ManagerAuthenticationResponse>
		//	{
		//		Success = Response.Success,
		//		ResponseData = Response.ResponseData
		//	};
		//}

		//[HttpDelete]
		//[Route("api/managerauthentication")]
		//[Produces(typeof(ServiceResponse<ManagerAuthenticationResponse>))]
		//public async Task<ServiceResponse<ManagerAuthenticationResponse>> Delete([FromBody] ManagerAuthenticationDelete Model)
		//{
		//	ServiceResponse<ManagerAuthenticationResponse> Response = await Service.DeleteAsync(Model);
		//	return new ServiceResponse<ManagerAuthenticationResponse>
		//	{
		//		Success = Response.Success,
		//		ResponseData = Response.ResponseData
		//	};
		//}

		[HttpGet]
		[Route("api/managerauthentication")]
		[Produces(typeof(ServiceResponse<ManagerAuthentication>))]
		public async Task<ServiceResponse<ManagerAuthentication>> Get([FromQuery] ManagerAuthenticationSelect Model)
		{
			DataService<ManagerAuthentication> Response = await Service.SelectAsync(Model);
			return ServiceResponse<ManagerAuthentication>.SuccessResponse(Response.DataList, "managerauthentication list");
		}

		//[HttpGet]
		//[Route("api/managerauthenticationsingle")]
		//[Produces(typeof(ServiceResponse<ManagerAuthenticationResponse>))]
		//public async Task<ServiceResponse<ManagerAuthenticationResponse>> GetSingle([FromQuery] ManagerAuthenticationSelectSingle Model)
		//{
		//	ServiceResponse<ManagerAuthenticationResponse> Response = await Service.SelectSingleAsync(Model);
		//	return new ServiceResponse<ManagerAuthenticationResponse>
		//	{
		//		ResponseDataSource = Response.ResponseDataSource
		//	};
		//}
	}
}