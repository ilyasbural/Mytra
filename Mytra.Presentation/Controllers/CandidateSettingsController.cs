namespace Mytra.Presentation.Controllers
{
	using Core;
	using Utilize;
	using AutoMapper;
	using Microsoft.AspNetCore.Mvc;

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
		[Route("api/candidatesettings")]
		[Produces(typeof(ServiceResponse<CandidateSettingsResponse>))]
		public async Task<ServiceResponse<CandidateSettingsResponse>> Create([FromBody] CandidateSettingsInsert Model)
		{
			DataService<CandidateSettings> Response = await Service.InsertAsync(Model);
			if (Response.Errors.Count > 0) return ServiceResponse<CandidateSettingsResponse>.FailureResponse(Response.Errors, "");
			if (!Response.Success) return ServiceResponse<CandidateSettingsResponse>.FailureResponse("");
			return ServiceResponse<CandidateSettingsResponse>.SuccessResponse(Mapper.Map<CandidateSettingsResponse>(Response.Data), "");
		}

		[HttpPut]
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
		[Route("api/candidatesettings/{id}")]
		[Produces(typeof(ServiceResponse<CandidateSettings>))]
		public async Task<ServiceResponse<CandidateSettings>> Delete(Guid Id)
		{
			DataService<CandidateSettings> Response = await Service.DeleteAsync(Id);
			if (Response.Errors.Count > 0) return ServiceResponse<CandidateSettings>.FailureResponse(Response.Errors, "");
			if (!Response.Success) return ServiceResponse<CandidateSettings>.FailureResponse("");
			return ServiceResponse<CandidateSettings>.SuccessResponse(Response.Data, "");
		}

		[HttpGet]
		[Route("api/candidatesettings")]
		[Produces(typeof(ServiceResponse<CandidateSettingsResponse>))]
		public async Task<ServiceResponse<CandidateSettingsResponse>> Get([FromQuery] CandidateSettingsSelect Model)
		{
			DataService<CandidateSettings> Response = await Service.SelectAsync(Model);
			return ServiceResponse<CandidateSettingsResponse>.SuccessResponse(Mapper.Map<List<CandidateSettingsResponse>>(Response.DataList), "");
		}

		[HttpGet]
		[Route("api/candidatesettingssingle")]
		[Produces(typeof(ServiceResponse<CandidateSettingsResponse>))]
		public async Task<ServiceResponse<CandidateSettingsResponse>> GetSingle([FromQuery] CandidateSettingsSelectSingle Model)
		{
			DataService<CandidateSettings> Response = await Service.SelectSingleAsync(Model);
			return ServiceResponse<CandidateSettingsResponse>.SuccessResponse(Mapper.Map<CandidateSettingsResponse>(Response.Data), "");
		}
	}
}