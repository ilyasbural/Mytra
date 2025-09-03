namespace Mytra.Presentation.Controllers
{
	using Core;
	using Common;
	using AutoMapper;
	using Microsoft.AspNetCore.Mvc;
	using Microsoft.AspNetCore.Authorization;

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
		[Route("api/managerdetail")]
		[Produces(typeof(ServiceResponse<ManagerDetail>))]
		public async Task<ServiceResponse<ManagerDetail>> Create([FromBody] ManagerDetailInsert Model)
		{
			DataService<ManagerDetail> Response = await Service.InsertAsync(Model);
			if (Response.Errors.Count > 0) return ServiceResponse<ManagerDetail>.FailureResponse(Response.Errors, "");
			if (!Response.Success) return ServiceResponse<ManagerDetail>.FailureResponse("");
			return ServiceResponse<ManagerDetail>.SuccessResponse(Response.Data, "");
		}

		[HttpPut]
		[Authorize]
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
		[Authorize]
		[Route("api/managerdetail")]
		[Produces(typeof(ServiceResponse<ManagerDetail>))]
		public async Task<ServiceResponse<ManagerDetail>> Delete([FromBody] ManagerDetailDelete Model)
		{
			DataService<ManagerDetail> Response = await Service.DeleteAsync(Model);
			if (Response.Errors.Count > 0) return ServiceResponse<ManagerDetail>.FailureResponse(Response.Errors, "");
			if (!Response.Success) return ServiceResponse<ManagerDetail>.FailureResponse("");
			return ServiceResponse<ManagerDetail>.SuccessResponse(Response.Data, "");
		}

		[HttpGet]
		[Authorize]
		[Route("api/managerdetail")]
		[Produces(typeof(ServiceResponse<ManagerDetailResponse>))]
		public async Task<ServiceResponse<ManagerDetailResponse>> Get([FromQuery] ManagerDetailSelect Model)
		{
			DataService<ManagerDetail> Response = await Service.SelectAsync(Model);
			return ServiceResponse<ManagerDetailResponse>.SuccessResponse(Mapper.Map<List<ManagerDetailResponse>>(Response.DataList), "");
		}

		[HttpGet]
		[Authorize]
		[Route("api/managerdetailsingle")]
		[Produces(typeof(ServiceResponse<ManagerDetailResponse>))]
		public async Task<ServiceResponse<ManagerDetailResponse>> GetSingle([FromQuery] ManagerDetailSelectSingle Model)
		{
			DataService<ManagerDetail> Response = await Service.SelectSingleAsync(Model);
			return ServiceResponse<ManagerDetailResponse>.SuccessResponse(Mapper.Map<List<ManagerDetailResponse>>(Response.Data), "");
		}
	}
}