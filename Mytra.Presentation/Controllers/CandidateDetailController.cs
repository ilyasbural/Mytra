namespace Mytra.Presentation.Controllers
{
	using Core;
	using Common;
	using AutoMapper;
	using Microsoft.AspNetCore.Mvc;
	using Microsoft.AspNetCore.Authorization;

	[ApiController]
    public class CandidateDetailController : ControllerBase
    {
		readonly IMapper Mapper;
		readonly ICandidateDetailService Service;
		public CandidateDetailController(IMapper mapper, ICandidateDetailService service)
		{
			Mapper = mapper;
			Service = service;
		}

		[HttpPost]
		[Authorize]
		[Route("api/candidatedetail")]
		[Produces(typeof(ServiceResponse<CandidateDetailResponse>))]
		public async Task<ServiceResponse<CandidateDetailResponse>> Create([FromBody] CandidateDetailInsert Model)
		{
			DataService<CandidateDetail> Response = await Service.InsertAsync(Model);
			if (Response.Errors.Count > 0) return ServiceResponse<CandidateDetailResponse>.FailureResponse(Response.Errors, "");
			if (!Response.Success) return ServiceResponse<CandidateDetailResponse>.FailureResponse("");
			return ServiceResponse<CandidateDetailResponse>.SuccessResponse(Mapper.Map<List<CandidateDetailResponse>>(Response.Data), "");
		}

		[HttpPut]
		[Authorize]
		[Route("api/candidatedetail")]
		[Produces(typeof(ServiceResponse<CandidateDetail>))]
		public async Task<ServiceResponse<CandidateDetail>> Update([FromBody] CandidateDetailUpdate Model)
		{
			DataService<CandidateDetail> Response = await Service.UpdateAsync(Model);
			if (Response.Errors.Count > 0) return ServiceResponse<CandidateDetail>.FailureResponse(Response.Errors, "");
			if (!Response.Success) return ServiceResponse<CandidateDetail>.FailureResponse("");
			return ServiceResponse<CandidateDetail>.SuccessResponse(Response.Data, "");
		}

		[HttpDelete]
		[Authorize]
		[Route("api/candidatedetail")]
		[Produces(typeof(ServiceResponse<CandidateDetail>))]
		public async Task<ServiceResponse<CandidateDetail>> Delete([FromBody] CandidateDetailDelete Model)
		{
			DataService<CandidateDetail> Response = await Service.DeleteAsync(Model);
			if (Response.Errors.Count > 0) return ServiceResponse<CandidateDetail>.FailureResponse(Response.Errors, "");
			if (!Response.Success) return ServiceResponse<CandidateDetail>.FailureResponse("");
			return ServiceResponse<CandidateDetail>.SuccessResponse(Response.Data, "");
		}

		[HttpGet]
		[Authorize]
		[Route("api/candidatedetail")]
		[Produces(typeof(ServiceResponse<CandidateDetailResponse>))]
		public async Task<ServiceResponse<CandidateDetailResponse>> Get([FromQuery] CandidateDetailSelect Model)
		{
			DataService<CandidateDetail> Response = await Service.SelectAsync(Model);
			return ServiceResponse<CandidateDetailResponse>.SuccessResponse(Mapper.Map<List<CandidateDetailResponse>>(Response.DataList), "");
		}

		[HttpGet]
		[Authorize]
		[Route("api/candidatedetailsingle")]
		[Produces(typeof(ServiceResponse<CandidateDetailResponse>))]
		public async Task<ServiceResponse<CandidateDetailResponse>> GetSingle([FromQuery] CandidateDetailSelectSingle Model)
		{
			DataService<CandidateDetail> Response = await Service.SelectSingleAsync(Model);
			return ServiceResponse<CandidateDetailResponse>.SuccessResponse(Mapper.Map<List<CandidateDetailResponse>>(Response.Data), "");
		}
	}
}