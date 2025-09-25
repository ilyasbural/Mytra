namespace Mytra.Presentation.Controllers
{
	using Core;
	using Utilize;
	using AutoMapper;
	using Microsoft.AspNetCore.Mvc;

	[ApiController]
	public class ManagerDetailController : ControllerBase
	{
		readonly IMapper Mapper;
		readonly IManagerDetailService Service;
		public ManagerDetailController(IMapper mapper, IManagerDetailService service)
		{
			Mapper = mapper;
			Service = service;
		}

		[HttpPost]
		[Route("api/managerdetail")]
		[Produces(typeof(ServiceResponse<ManagerDetailResponse>))]
		public async Task<ServiceResponse<ManagerDetailResponse>> Create([FromBody] ManagerDetailInsert Model)
		{
			DataService<ManagerDetail> Response = await Service.InsertAsync(Model);
			if (Response.Errors.Count > 0) return ServiceResponse<ManagerDetailResponse>.FailureResponse(Response.Errors, "");
			if (!Response.Success) return ServiceResponse<ManagerDetailResponse>.FailureResponse("");
			return ServiceResponse<ManagerDetailResponse>.SuccessResponse(Mapper.Map<ManagerDetailResponse>(Response.Data), "");
		}

		[HttpPut]
		[Route("api/managerdetail")]
		[Produces(typeof(ServiceResponse<ManagerDetail>))]
		public async Task<ServiceResponse<ManagerDetail>> Update([FromBody] ManagerDetailUpdate Model)
		{
			DataService<ManagerDetail> Response = await Service.UpdateAsync(Model);
			if (Response.Errors.Count > 0) return ServiceResponse<ManagerDetail>.FailureResponse(Response.Errors, "");
			if (!Response.Success) return ServiceResponse<ManagerDetail>.FailureResponse("");
			return ServiceResponse<ManagerDetail>.SuccessResponse(Response.Data, "");
		}

		[HttpDelete]
		[Route("api/managerdetail/{id}")]
		[Produces(typeof(ServiceResponse<ManagerDetail>))]
		public async Task<ServiceResponse<ManagerDetail>> Delete(Guid Id)
		{
			DataService<ManagerDetail> Response = await Service.DeleteAsync(Id);
			if (Response.Errors.Count > 0) return ServiceResponse<ManagerDetail>.FailureResponse(Response.Errors, "");
			if (!Response.Success) return ServiceResponse<ManagerDetail>.FailureResponse("");
			return ServiceResponse<ManagerDetail>.SuccessResponse(Response.Data, "");
		}

		[HttpGet]
		[Route("api/managerdetail")]
		[Produces(typeof(ServiceResponse<ManagerDetailResponse>))]
		public async Task<ServiceResponse<ManagerDetailResponse>> Get([FromQuery] ManagerDetailSelect Model)
		{
			DataService<ManagerDetail> Response = await Service.SelectAsync(Model);
			return ServiceResponse<ManagerDetailResponse>.SuccessResponse(Mapper.Map<List<ManagerDetailResponse>>(Response.DataList), "");
		}

		[HttpGet]
		[Route("api/managerdetailsingle")]
		[Produces(typeof(ServiceResponse<ManagerDetailResponse>))]
		public async Task<ServiceResponse<ManagerDetailResponse>> GetSingle([FromQuery] ManagerDetailSelectSingle Model)
		{
			DataService<ManagerDetail> Response = await Service.SelectSingleAsync(Model);
			return ServiceResponse<ManagerDetailResponse>.SuccessResponse(Mapper.Map<ManagerDetailResponse>(Response.Data), "");
		}
	}
}