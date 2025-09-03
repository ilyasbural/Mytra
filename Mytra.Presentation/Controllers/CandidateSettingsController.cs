namespace Mytra.Presentation.Controllers
{
	using Core;
	using Common;
	using AutoMapper;
	using Microsoft.AspNetCore.Mvc;
	using Microsoft.AspNetCore.Authorization;

	[ApiController]
    public class CandidateSettingsController : ControllerBase
    {
		readonly IMapper Mapper;
		readonly ICandidateSettingsService Service;
		public CandidateSettingsController(IMapper mapper, ICandidateSettingsService service)
		{
			Mapper = mapper;
			Service = service;
		}

		[HttpPost]
		[Route("api/candidate")]
		[Produces(typeof(ServiceResponse<CandidateResponse>))]
		public async Task<ServiceResponse<CandidateResponse>> Create([FromBody] CandidateInsert Model)
		{
			DataService<Candidate> Response = await Service.InsertAsync(Model);
			if (Response.Errors.Count > 0) return ServiceResponse<CandidateResponse>.FailureResponse(Response.Errors, "");
			if (!Response.Success) return ServiceResponse<CandidateResponse>.FailureResponse("");
			return ServiceResponse<CandidateResponse>.SuccessResponse(Mapper.Map<List<CandidateResponse>>(Response.Data), "");
		}

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
		[Produces(typeof(ServiceResponse<CandidateSettingsResponse>))]
		public async Task<ServiceResponse<CandidateSettingsResponse>> Get([FromQuery] CandidateSettingsSelect Model)
		{
			DataService<CandidateSettings> Response = await Service.SelectAsync(Model);
			return ServiceResponse<CandidateSettingsResponse>.SuccessResponse(Mapper.Map<List<CandidateSettingsResponse>>(Response.DataList), "");
		}

		[HttpGet]
		[Authorize]
		[Route("api/candidatesettingssingle")]
		[Produces(typeof(ServiceResponse<CandidateSettingsResponse>))]
		public async Task<ServiceResponse<CandidateSettingsResponse>> GetSingle([FromQuery] CandidateSettingsSelectSingle Model)
		{
			DataService<CandidateSettings> Response = await Service.SelectSingleAsync(Model);
			return ServiceResponse<CandidateSettingsResponse>.SuccessResponse(Mapper.Map<List<CandidateSettingsResponse>>(Response.Data), "");
		}
	}
}