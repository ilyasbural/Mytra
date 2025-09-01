namespace Mytra.Presentation.Controllers
{
	using Core;
	using Common;
	using Microsoft.AspNetCore.Mvc;
	using Microsoft.AspNetCore.Authorization;

	[ApiController]
	public class ManagerSettingsController : ControllerBase
	{
		readonly IManagerSettingsService Service;
		public ManagerSettingsController(IManagerSettingsService service) { Service = service; }

		[HttpPost]
		[Route("api/managersettings")]
		[Produces(typeof(ServiceResponse<ManagerSettings>))]
		public async Task<ServiceResponse<ManagerSettings>> Create([FromBody] ManagerSettingsInsert Model)
		{
			DataService<ManagerSettings> Response = await Service.InsertAsync(Model);
			if (Response.Errors.Count > 0) return ServiceResponse<ManagerSettings>.FailureResponse(Response.Errors, "");
			if (!Response.Success) return ServiceResponse<ManagerSettings>.FailureResponse("");
			return ServiceResponse<ManagerSettings>.SuccessResponse(Response.Data, "");
		}

		//[HttpPut]
		//[Route("api/managersettings")]
		//[Produces(typeof(ServiceResponse<ManagerSettingsResponse>))]
		//public async Task<ServiceResponse<ManagerSettingsResponse>> Update([FromBody] ManagerSettingsUpdate Model)
		//{
		//	ServiceResponse<ManagerSettingsResponse> Response = await Service.UpdateAsync(Model);
		//	return new ServiceResponse<ManagerSettingsResponse>
		//	{
		//		Success = Response.Success,
		//		ResponseData = Response.ResponseData
		//	};
		//}

		//[HttpDelete]
		//[Route("api/managersettings")]
		//[Produces(typeof(ServiceResponse<ManagerSettingsResponse>))]
		//public async Task<ServiceResponse<ManagerSettingsResponse>> Delete([FromBody] ManagerSettingsDelete Model)
		//{
		//	ServiceResponse<ManagerSettingsResponse> Response = await Service.DeleteAsync(Model);
		//	return new ServiceResponse<ManagerSettingsResponse>
		//	{
		//		Success = Response.Success,
		//		ResponseData = Response.ResponseData
		//	};
		//}

		[HttpGet]
		[Route("api/managersettings")]
		[Produces(typeof(ServiceResponse<ManagerSettings>))]
		public async Task<ServiceResponse<ManagerSettings>> Get([FromQuery] ManagerSettingsSelect Model)
		{
			DataService<ManagerSettings> Response = await Service.SelectAsync(Model);
			return ServiceResponse<ManagerSettings>.SuccessResponse(Response.DataList, "managersettings list added");
		}

		//[HttpGet]
		//[Route("api/managersettingssingle")]
		//[Produces(typeof(ServiceResponse<ManagerSettingsResponse>))]
		//public async Task<ServiceResponse<ManagerSettingsResponse>> GetSingle([FromQuery] ManagerSettingsSelectSingle Model)
		//{
		//	ServiceResponse<ManagerSettingsResponse> Response = await Service.SelectSingleAsync(Model);
		//	return new ServiceResponse<ManagerSettingsResponse>
		//	{
		//		ResponseDataSource = Response.ResponseDataSource
		//	};
		//}
	}
}