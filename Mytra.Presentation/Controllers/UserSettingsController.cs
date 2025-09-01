namespace Mytra.Presentation.Controllers
{
	using Core;
	using Common;
	using Microsoft.AspNetCore.Mvc;
	using Microsoft.AspNetCore.Authorization;

	[ApiController]
	public class UserSettingsController : ControllerBase
	{
		readonly IUserSettingsService Service;
		public UserSettingsController(IUserSettingsService service) { Service = service; }

		[HttpPost]
		[Route("api/usersettings")]
		[Produces(typeof(ServiceResponse<UserSettings>))]
		public async Task<ServiceResponse<UserSettings>> Create([FromBody] UserSettingsInsert Model)
		{
			DataService<UserSettings> Response = await Service.InsertAsync(Model);
			if (Response.Errors.Count > 0) return ServiceResponse<UserSettings>.FailureResponse(Response.Errors, "");
			if (!Response.Success) return ServiceResponse<UserSettings>.FailureResponse("");
			return ServiceResponse<UserSettings>.SuccessResponse(Response.Data, "");
		}

		[HttpPut]
		[Route("api/usersettings")]
		[Produces(typeof(ServiceResponse<UserSettings>))]
		public async Task<ServiceResponse<UserSettings>> Update([FromBody] UserSettingsUpdate Model)
		{
			DataService<UserSettings> Response = await Service.UpdateAsync(Model);
			if (Response.Errors.Count > 0) return ServiceResponse<UserSettings>.FailureResponse(Response.Errors, "");
			if (!Response.Success) return ServiceResponse<UserSettings>.FailureResponse("");
			return ServiceResponse<UserSettings>.SuccessResponse(Response.Data, "");
		}

		[HttpDelete]
		[Route("api/usersettings")]
		[Produces(typeof(ServiceResponse<UserSettings>))]
		public async Task<ServiceResponse<UserSettings>> Delete([FromBody] UserSettingsDelete Model)
		{
			DataService<UserSettings> Response = await Service.DeleteAsync(Model);
			if (Response.Errors.Count > 0) return ServiceResponse<UserSettings>.FailureResponse(Response.Errors, "");
			if (!Response.Success) return ServiceResponse<UserSettings>.FailureResponse("");
			return ServiceResponse<UserSettings>.SuccessResponse(Response.Data, "");
		}

		[HttpGet]
		[Route("api/usersettings")]
		[Produces(typeof(ServiceResponse<UserSettings>))]
		public async Task<ServiceResponse<UserSettings>> Get([FromQuery] UserSettingsSelect Model)
		{
			DataService<UserSettings> Response = await Service.SelectAsync(Model);
			return ServiceResponse<UserSettings>.SuccessResponse(Response.DataList, "usersettings list added");
		}

		[HttpGet]
		[Route("api/usersettingssingle")]
		[Produces(typeof(ServiceResponse<UserSettings>))]
		public async Task<ServiceResponse<UserSettings>> GetSingle([FromQuery] UserSettingsSelectSingle Model)
		{
			DataService<UserSettings> Response = await Service.SelectSingleAsync(Model);
			return ServiceResponse<UserSettings>.SuccessResponse(Response.Data, "");
		}
	}
}