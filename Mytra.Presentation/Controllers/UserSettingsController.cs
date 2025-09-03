namespace Mytra.Presentation.Controllers
{
	using Core;
	using Common;
	using AutoMapper;
	using Microsoft.AspNetCore.Mvc;
	using Microsoft.AspNetCore.Authorization;

	[ApiController]
	public class UserSettingsController : ControllerBase
	{
		readonly IMapper Mapper;
		readonly IUserSettingsService Service;
		public UserSettingsController(IMapper mapper, IUserSettingsService service)
		{
			Mapper = mapper;
			Service = service;
		}

		[HttpPost]
		[Authorize]
		[Route("api/usersettings")]
		[Produces(typeof(ServiceResponse<UserSettingsResponse>))]
		public async Task<ServiceResponse<UserSettingsResponse>> Create([FromBody] UserSettingsInsert Model)
		{
			DataService<UserSettings> Response = await Service.InsertAsync(Model);
			if (Response.Errors.Count > 0) return ServiceResponse<UserSettingsResponse>.FailureResponse(Response.Errors, "");
			if (!Response.Success) return ServiceResponse<UserSettingsResponse>.FailureResponse("");
			return ServiceResponse<UserSettingsResponse>.SuccessResponse(Mapper.Map<List<UserSettingsResponse>>(Response.Data), "");
		}

		[HttpPut]
		[Authorize]
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
		[Authorize]
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
		[Authorize]
		[Route("api/usersettings")]
		[Produces(typeof(ServiceResponse<UserSettingsResponse>))]
		public async Task<ServiceResponse<UserSettingsResponse>> Get([FromQuery] UserSettingsSelect Model)
		{
			DataService<UserSettings> Response = await Service.SelectAsync(Model);
			return ServiceResponse<UserSettingsResponse>.SuccessResponse(Mapper.Map<List<UserSettingsResponse>>(Response.DataList), "");
		}

		[HttpGet]
		[Authorize]
		[Route("api/usersettingssingle")]
		[Produces(typeof(ServiceResponse<UserSettingsResponse>))]
		public async Task<ServiceResponse<UserSettingsResponse>> GetSingle([FromQuery] UserSettingsSelectSingle Model)
		{
			DataService<UserSettings> Response = await Service.SelectSingleAsync(Model);
			return ServiceResponse<UserSettingsResponse>.SuccessResponse(Mapper.Map<List<UserSettingsResponse>>(Response.Data), "");
		}
	}
}