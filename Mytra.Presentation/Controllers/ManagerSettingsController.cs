namespace Mytra.Presentation.Controllers
{
	using Core;
	using Utilize;
	using AutoMapper;
	using Microsoft.AspNetCore.Mvc;

	[ApiController]
	public class ManagerSettingsController : ControllerBase
	{
		readonly IMapper Mapper;
		readonly IManagerSettingsService Service;
		public ManagerSettingsController(IMapper mapper, IManagerSettingsService service)
		{
			Mapper = mapper;
			Service = service;
		}

		[HttpPost]
		[Route("api/managersettings")]
		[Produces(typeof(ServiceResponse<ManagerSettingsResponse>))]
		public async Task<ServiceResponse<ManagerSettingsResponse>> Create([FromBody] ManagerSettingsInsert Model)
		{
			DataService<ManagerSettings> Response = await Service.InsertAsync(Model);
			if (Response.Errors.Count > 0) return ServiceResponse<ManagerSettingsResponse>.FailureResponse(Response.Errors, "");
			if (!Response.Success) return ServiceResponse<ManagerSettingsResponse>.FailureResponse("");
			return ServiceResponse<ManagerSettingsResponse>.SuccessResponse(Mapper.Map<ManagerSettingsResponse>(Response.Data), "");
		}

		[HttpPut]
		[Route("api/managersettings")]
		[Produces(typeof(ServiceResponse<ManagerSettings>))]
		public async Task<ServiceResponse<ManagerSettings>> Update([FromBody] ManagerSettingsUpdate Model)
		{
			DataService<ManagerSettings> Response = await Service.UpdateAsync(Model);
			if (Response.Errors.Count > 0) return ServiceResponse<ManagerSettings>.FailureResponse(Response.Errors, "");
			if (!Response.Success) return ServiceResponse<ManagerSettings>.FailureResponse("");
			return ServiceResponse<ManagerSettings>.SuccessResponse(Response.Data, "");
		}

		[HttpDelete]
		[Route("api/managersettings/{id}")]
		[Produces(typeof(ServiceResponse<ManagerSettings>))]
		public async Task<ServiceResponse<ManagerSettings>> Delete(Guid Id)
		{
			DataService<ManagerSettings> Response = await Service.DeleteAsync(Id);
			if (Response.Errors.Count > 0) return ServiceResponse<ManagerSettings>.FailureResponse(Response.Errors, "");
			if (!Response.Success) return ServiceResponse<ManagerSettings>.FailureResponse("");
			return ServiceResponse<ManagerSettings>.SuccessResponse(Response.Data, "");
		}

		[HttpGet]
		[Route("api/managersettings")]
		[Produces(typeof(ServiceResponse<ManagerSettingsResponse>))]
		public async Task<ServiceResponse<ManagerSettingsResponse>> Get([FromQuery] ManagerSettingsSelect Model)
		{
			DataService<ManagerSettings> Response = await Service.SelectAsync(Model);
			return ServiceResponse<ManagerSettingsResponse>.SuccessResponse(Mapper.Map<List<ManagerSettingsResponse>>(Response.DataList), "");
		}

		[HttpGet]
		[Route("api/managersettingssingle")]
		[Produces(typeof(ServiceResponse<ManagerSettingsResponse>))]
		public async Task<ServiceResponse<ManagerSettingsResponse>> GetSingle([FromQuery] ManagerSettingsSelectSingle Model)
		{
			DataService<ManagerSettings> Response = await Service.SelectSingleAsync(Model);
			return ServiceResponse<ManagerSettingsResponse>.SuccessResponse(Mapper.Map<ManagerSettingsResponse>(Response.Data), "");
		}
	}
}