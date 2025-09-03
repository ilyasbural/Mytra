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
		[Produces(typeof(ServiceResponse<CandidateSettings>))]
		public async Task<ServiceResponse<CandidateSettings>> Create([FromBody] CandidateSettingsInsert Model)
		{
			DataService<CandidateSettings> Response = await Service.InsertAsync(Model);
			if (Response.Errors.Count > 0) return ServiceResponse<CandidateSettings>.FailureResponse(Response.Errors, "");
			if (!Response.Success) return ServiceResponse<CandidateSettings>.FailureResponse("");
			return ServiceResponse<CandidateSettings>.SuccessResponse(Response.Data, "");
		}

		[HttpPut]
		[Authorize]
		[Route("api/candidatesettings")]
		[Produces(typeof(ServiceResponse<CandidateSettings>))]
		public async Task<ServiceResponse<CandidateSettings>> Update([FromBody] CandidateSettingsUpdate Model)
		{
			DataService<CandidateSettings> Response = await Service.UpdateAsync(Model);
			if (Response.Errors.Count > 0) return ServiceResponse<CandidateSettings>.FailureResponse(Response.Errors, "");
			if (!Response.Success) return ServiceResponse<CandidateSettings>.FailureResponse("");
			return ServiceResponse<CandidateSettings>.SuccessResponse(Response.Data, "");
		}

		[HttpDelete]
		[Authorize]
		[Route("api/candidatesettings")]
		[Produces(typeof(ServiceResponse<CandidateSettings>))]
		public async Task<ServiceResponse<CandidateSettings>> Delete([FromBody] CandidateSettingsDelete Model)
		{
			DataService<CandidateSettings> Response = await Service.DeleteAsync(Model);
			if (Response.Errors.Count > 0) return ServiceResponse<CandidateSettings>.FailureResponse(Response.Errors, "");
			if (!Response.Success) return ServiceResponse<CandidateSettings>.FailureResponse("");
			return ServiceResponse<CandidateSettings>.SuccessResponse(Response.Data, "");
		}

		[HttpGet]
		[Authorize]
		[Route("api/candidatesettings")]
		[Produces(typeof(ServiceResponse<CandidateSettings>))]
		public async Task<ServiceResponse<CandidateSettings>> Get([FromQuery] CandidateSettingsSelect Model)
		{
			DataService<CandidateSettings> Response = await Service.SelectAsync(Model);
			return ServiceResponse<CandidateSettings>.SuccessResponse(Response.DataList, "");
		}

		[HttpGet]
		[Authorize]
		[Route("api/candidatesettingssingle")]
		[Produces(typeof(ServiceResponse<CandidateSettings>))]
		public async Task<ServiceResponse<CandidateSettings>> GetSingle([FromQuery] CandidateSettingsSelectSingle Model)
		{
			DataService<CandidateSettings> Response = await Service.SelectSingleAsync(Model);
			return ServiceResponse<CandidateSettings>.SuccessResponse(Response.Data, "");
		}
	}
}