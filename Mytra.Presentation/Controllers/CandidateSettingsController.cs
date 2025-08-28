namespace Mytra.Presentation.Controllers
{
	using Core;
	using Common;
	using Microsoft.AspNetCore.Mvc;
	using Microsoft.AspNetCore.Authorization;

    [ApiController]
    public class CandidateSettingsController : ControllerBase
    {
		readonly ICandidateSettingsService Service;
		public CandidateSettingsController(ICandidateSettingsService service) { Service = service; }

		[HttpPost]
		[Authorize]
		[Route("api/candidatesettings")]
		[Produces(typeof(ServiceResponse<CandidateSettingsResponse>))]
		public async Task<ServiceResponse<CandidateSettingsResponse>> Create([FromBody] CandidateSettingsInsert Model)
		{
			ServiceResponse<CandidateSettingsResponse> Response = await Service.InsertAsync(Model);
			return new ServiceResponse<CandidateSettingsResponse>
			{
				ResponseData = Response.ResponseData
			};
		}
	}
}