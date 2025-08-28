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
		[Authorize]
		[Route("api/managersettings")]
		[Produces(typeof(ServiceResponse<ManagerSettingsResponse>))]
		public async Task<ServiceResponse<ManagerSettingsResponse>> Create([FromBody] ManagerSettingsInsert Model)
		{
			ServiceResponse<ManagerSettingsResponse> Response = await Service.InsertAsync(Model);
			return new ServiceResponse<ManagerSettingsResponse>
			{
				ResponseData = Response.ResponseData
			};
		}
	}
}