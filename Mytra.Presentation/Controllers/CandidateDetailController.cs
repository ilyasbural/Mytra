namespace Mytra.Presentation.Controllers
{
	using Core;
	using Utilize;
	using AutoMapper;
	using Microsoft.AspNetCore.Mvc;

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
		[Route("api/candidatedetail")]
		[Produces(typeof(ServiceResponse<CandidateDetailResponse>))]
		public async Task<ServiceResponse<CandidateDetailResponse>> Create([FromBody] CandidateDetailInsert Model)
		{
			DataService<CandidateDetail> Response = await Service.InsertAsync(Model);
			if (Response.Errors.Count > 0) return ServiceResponse<CandidateDetailResponse>.FailureResponse(Response.Errors, "");
			if (!Response.Success) return ServiceResponse<CandidateDetailResponse>.FailureResponse("");
			return ServiceResponse<CandidateDetailResponse>.SuccessResponse(Mapper.Map<CandidateDetailResponse>(Response.Data), "");
		}

		[HttpPut]
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
		[Route("api/candidatedetail/{id}")]
		[Produces(typeof(ServiceResponse<CandidateDetail>))]
		public async Task<ServiceResponse<CandidateDetail>> Delete(Guid Id)
		{
			DataService<CandidateDetail> Response = await Service.DeleteAsync(Id);
			if (Response.Errors.Count > 0) return ServiceResponse<CandidateDetail>.FailureResponse(Response.Errors, "");
			if (!Response.Success) return ServiceResponse<CandidateDetail>.FailureResponse("");
			return ServiceResponse<CandidateDetail>.SuccessResponse(Response.Data, "");
		}

		[HttpGet]
		[Route("api/candidatedetail")]
		[Produces(typeof(ServiceResponse<CandidateDetailResponse>))]
		public async Task<ServiceResponse<CandidateDetailResponse>> Get([FromQuery] CandidateDetailSelect Model)
		{
			DataService<CandidateDetail> Response = await Service.SelectAsync(Model);
			return ServiceResponse<CandidateDetailResponse>.SuccessResponse(Mapper.Map<List<CandidateDetailResponse>>(Response.DataList), "");
		}

		[HttpGet]
		[Route("api/candidatedetailsingle")]
		[Produces(typeof(ServiceResponse<CandidateDetailResponse>))]
		public async Task<ServiceResponse<CandidateDetailResponse>> GetSingle([FromQuery] CandidateDetailSelectSingle Model)
		{
			DataService<CandidateDetail> Response = await Service.SelectSingleAsync(Model);
			return ServiceResponse<CandidateDetailResponse>.SuccessResponse(Mapper.Map<CandidateDetailResponse>(Response.Data), "");
		}
	}
}