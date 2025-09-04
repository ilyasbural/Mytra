namespace Mytra.Presentation.Controllers
{
	using Core;
	using Common;
	using AutoMapper;
	using Microsoft.AspNetCore.Mvc;
	using Microsoft.AspNetCore.Authorization;

	[ApiController]
	public class ManagerController : ControllerBase
	{
		readonly IMapper Mapper;
		readonly IManagerService Service;
		public ManagerController(IMapper mapper, IManagerService service)
		{
			Mapper = mapper;
			Service = service;
		}

		[HttpPost]
		[Authorize]
		[Route("api/manager")]
		[Produces(typeof(ServiceResponse<ManagerResponse>))]
		public async Task<ServiceResponse<ManagerResponse>> Create([FromBody] ManagerInsert Model)
		{
			DataService<Manager> Response = await Service.InsertAsync(Model);
			if (Response.Errors.Count > 0) return ServiceResponse<ManagerResponse>.FailureResponse(Response.Errors, "");
			if (!Response.Success) return ServiceResponse<ManagerResponse>.FailureResponse("");
			return ServiceResponse<ManagerResponse>.SuccessResponse(Mapper.Map<List<ManagerResponse>>(Response.Data), "");
		}

		[HttpPut]
		[Authorize]
		[Route("api/manager")]
		[Produces(typeof(ServiceResponse<Manager>))]
		public async Task<ServiceResponse<Manager>> Update([FromBody] ManagerUpdate Model)
		{
			DataService<Manager> Response = await Service.UpdateAsync(Model);
			if (Response.Errors.Count > 0) return ServiceResponse<Manager>.FailureResponse(Response.Errors, "");
			if (!Response.Success) return ServiceResponse<Manager>.FailureResponse("");
			return ServiceResponse<Manager>.SuccessResponse(Response.Data, "");
		}

		[HttpDelete]
		[Authorize]
		[Route("api/manager")]
		[Produces(typeof(ServiceResponse<Manager>))]
		public async Task<ServiceResponse<Manager>> Delete([FromBody] ManagerDelete Model)
		{
			DataService<Manager> Response = await Service.DeleteAsync(Model);
			if (Response.Errors.Count > 0) return ServiceResponse<Manager>.FailureResponse(Response.Errors, "");
			if (!Response.Success) return ServiceResponse<Manager>.FailureResponse("");
			return ServiceResponse<Manager>.SuccessResponse(Response.Data, "");
		}

		[HttpGet]
		[Authorize]
		[Route("api/manager")]
		[Produces(typeof(ServiceResponse<ManagerResponse>))]
		public async Task<ServiceResponse<ManagerResponse>> Get([FromQuery] ManagerSelect Model)
		{
			DataService<Manager> Response = await Service.SelectAsync(Model);
			return ServiceResponse<ManagerResponse>.SuccessResponse(Mapper.Map<List<ManagerResponse>>(Response.DataList), "");
		}

		[HttpGet]
		[Authorize]
		[Route("api/managersingle")]
		[Produces(typeof(ServiceResponse<ManagerResponse>))]
		public async Task<ServiceResponse<ManagerResponse>> GetSingle([FromQuery] ManagerSelectSingle Model)
		{
			DataService<Manager> Response = await Service.SelectSingleAsync(Model);
			return ServiceResponse<ManagerResponse>.SuccessResponse(Mapper.Map<List<ManagerResponse>>(Response.Data), "");
		}
	}
}