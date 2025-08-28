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
		[Authorize]
		[Route("api/usersettings")]
		[Produces(typeof(ServiceResponse<UserSettingsResponse>))]
		public async Task<ServiceResponse<UserSettingsResponse>> Create([FromBody] UserSettingsInsert Model)
		{
			ServiceResponse<UserSettingsResponse> Response = await Service.InsertAsync(Model);
			return new ServiceResponse<UserSettingsResponse>
			{
				ResponseData = Response.ResponseData
			};
		}
	}
}