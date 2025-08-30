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
		[Produces(typeof(ServiceResponse<UserSettingsResponse>))]
		public async Task<ServiceResponse<UserSettingsResponse>> Create([FromBody] UserSettingsInsert Model)
		{
			ServiceResponse<UserSettingsResponse> Response = await Service.InsertAsync(Model);
			return new ServiceResponse<UserSettingsResponse>
			{
				Success = Response.Success,
				ResponseData = Response.ResponseData
			};
		}

		[HttpPut]
		[Route("api/usersettings")]
		[Produces(typeof(ServiceResponse<UserSettingsResponse>))]
		public async Task<ServiceResponse<UserSettingsResponse>> Update([FromBody] UserSettingsUpdate Model)
		{
			ServiceResponse<UserSettingsResponse> Response = await Service.UpdateAsync(Model);
			return new ServiceResponse<UserSettingsResponse>
			{
				Success = Response.Success,
				ResponseData = Response.ResponseData
			};
		}

		[HttpDelete]
		[Route("api/usersettings")]
		[Produces(typeof(ServiceResponse<UserSettingsResponse>))]
		public async Task<ServiceResponse<UserSettingsResponse>> Delete([FromBody] UserSettingsDelete Model)
		{
			ServiceResponse<UserSettingsResponse> Response = await Service.DeleteAsync(Model);
			return new ServiceResponse<UserSettingsResponse>
			{
				Success = Response.Success,
				ResponseData = Response.ResponseData
			};
		}

		[HttpGet]
		[Route("api/usersettings")]
		[Produces(typeof(ServiceResponse<UserSettingsResponse>))]
		public async Task<ServiceResponse<UserSettingsResponse>> Get([FromQuery] UserSettingsSelect Model)
		{
			ServiceResponse<UserSettingsResponse> Response = await Service.SelectAsync(Model);
			return new ServiceResponse<UserSettingsResponse>
			{
				ResponseDataSource = Response.ResponseDataSource
			};
		}

		[HttpGet]
		[Route("api/usersettingssingle")]
		[Produces(typeof(ServiceResponse<UserSettingsResponse>))]
		public async Task<ServiceResponse<UserSettingsResponse>> GetSingle([FromQuery] UserSettingsSelectSingle Model)
		{
			ServiceResponse<UserSettingsResponse> Response = await Service.SelectSingleAsync(Model);
			return new ServiceResponse<UserSettingsResponse>
			{
				ResponseDataSource = Response.ResponseDataSource
			};
		}
	}
}