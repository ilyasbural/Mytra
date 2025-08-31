namespace Mytra.Presentation.Controllers
{
	using Core;
	using Common;
	using Microsoft.AspNetCore.Mvc;
	using Microsoft.AspNetCore.Authorization;

	[ApiController]
	public class ManagerController : ControllerBase
	{
		//readonly IManagerService Service;
		//public ManagerController(IManagerService service) { Service = service; }

		//[HttpPost]
		//[Route("api/manager")]
		//[Produces(typeof(ServiceResponse<ManagerResponse>))]
		//public async Task<ServiceResponse<ManagerResponse>> Create([FromBody] ManagerInsert Model)
		//{
		//	ServiceResponse<ManagerResponse> Response = await Service.InsertAsync(Model);
		//	return new ServiceResponse<ManagerResponse>
		//	{
		//		Success = Response.Success,
		//		ResponseData = Response.ResponseData
		//	};
		//}

		//[HttpPut]
		//[Route("api/manager")]
		//[Produces(typeof(ServiceResponse<ManagerResponse>))]
		//public async Task<ServiceResponse<ManagerResponse>> Update([FromBody] ManagerUpdate Model)
		//{
		//	ServiceResponse<ManagerResponse> Response = await Service.UpdateAsync(Model);
		//	return new ServiceResponse<ManagerResponse>
		//	{
		//		Success = Response.Success,
		//		ResponseData = Response.ResponseData
		//	};
		//}

		//[HttpDelete]
		//[Route("api/manager")]
		//[Produces(typeof(ServiceResponse<ManagerResponse>))]
		//public async Task<ServiceResponse<ManagerResponse>> Delete([FromBody] ManagerDelete Model)
		//{
		//	ServiceResponse<ManagerResponse> Response = await Service.DeleteAsync(Model);
		//	return new ServiceResponse<ManagerResponse>
		//	{
		//		Success = Response.Success,
		//		ResponseData = Response.ResponseData
		//	};
		//}

		//[HttpGet]
		//[Route("api/manager")]
		//[Produces(typeof(ServiceResponse<ManagerResponse>))]
		//public async Task<ServiceResponse<ManagerResponse>> Get([FromQuery] ManagerSelect Model)
		//{
		//	ServiceResponse<ManagerResponse> Response = await Service.SelectAsync(Model);
		//	return new ServiceResponse<ManagerResponse>
		//	{
		//		ResponseDataSource = Response.ResponseDataSource
		//	};
		//}

		//[HttpGet]
		//[Route("api/managersingle")]
		//[Produces(typeof(ServiceResponse<ManagerResponse>))]
		//public async Task<ServiceResponse<ManagerResponse>> GetSingle([FromQuery] ManagerSelectSingle Model)
		//{
		//	ServiceResponse<ManagerResponse> Response = await Service.SelectSingleAsync(Model);
		//	return new ServiceResponse<ManagerResponse>
		//	{
		//		ResponseDataSource = Response.ResponseDataSource
		//	};
		//}
	}
}