namespace Mytra.Presentation.Controllers
{
	using Core;
	using Common;
	using AutoMapper;
	using Microsoft.AspNetCore.Mvc;
	using Microsoft.AspNetCore.Authorization;

	[ApiController]
    public class CandidateReferanceController : ControllerBase
    {
		readonly IMapper Mapper;
		readonly ICandidateReferanceService Service;
		public CandidateReferanceController(IMapper mapper, ICandidateReferanceService service)
		{
			Mapper = mapper;
			Service = service;
		}

		[HttpPost]
		[Authorize]
		[Route("api/candidatereferance")]
		[Produces(typeof(ServiceResponse<CandidateReferanceResponse>))]
		public async Task<ServiceResponse<CandidateReferanceResponse>> Create([FromBody] CandidateReferanceInsert Model)
		{
			DataService<CandidateReferance> Response = await Service.InsertAsync(Model);
			if (Response.Errors.Count > 0) return ServiceResponse<CandidateReferanceResponse>.FailureResponse(Response.Errors, "");
			if (!Response.Success) return ServiceResponse<CandidateReferanceResponse>.FailureResponse("");
			return ServiceResponse<CandidateReferanceResponse>.SuccessResponse(Mapper.Map<List<CandidateReferanceResponse>>(Response.Data), "");
		}

		[HttpPut]
		[Authorize]
		[Route("api/candidatereferance")]
		[Produces(typeof(ServiceResponse<CandidateReferance>))]
		public async Task<ServiceResponse<CandidateReferance>> Update([FromBody] CandidateReferanceUpdate Model)
		{
			DataService<CandidateReferance> Response = await Service.UpdateAsync(Model);
			if (Response.Errors.Count > 0) return ServiceResponse<CandidateReferance>.FailureResponse(Response.Errors, "");
			if (!Response.Success) return ServiceResponse<CandidateReferance>.FailureResponse("");
			return ServiceResponse<CandidateReferance>.SuccessResponse(Response.Data, "");
		}

		[HttpDelete]
		[Authorize]
		[Route("api/candidatereferance")]
		[Produces(typeof(ServiceResponse<CandidateReferance>))]
		public async Task<ServiceResponse<CandidateReferance>> Delete([FromBody] CandidateReferanceDelete Model)
		{
			DataService<CandidateReferance> Response = await Service.DeleteAsync(Model);
			if (Response.Errors.Count > 0) return ServiceResponse<CandidateReferance>.FailureResponse(Response.Errors, "");
			if (!Response.Success) return ServiceResponse<CandidateReferance>.FailureResponse("");
			return ServiceResponse<CandidateReferance>.SuccessResponse(Response.Data, "");
		}

		[HttpGet]
		[Authorize]
		[Route("api/candidatereferance")]
		[Produces(typeof(ServiceResponse<CandidateReferanceResponse>))]
		public async Task<ServiceResponse<CandidateReferanceResponse>> Get([FromQuery] CandidateReferanceSelect Model)
		{
			DataService<CandidateReferance> Response = await Service.SelectAsync(Model);
			return ServiceResponse<CandidateReferanceResponse>.SuccessResponse(Mapper.Map<List<CandidateReferanceResponse>>(Response.DataList), "");
		}

		[HttpGet]
		[Authorize]
		[Route("api/candidatereferancesingle")]
		[Produces(typeof(ServiceResponse<CandidateReferanceResponse>))]
		public async Task<ServiceResponse<CandidateReferanceResponse>> GetSingle([FromQuery] CandidateReferanceSelectSingle Model)
		{
			DataService<CandidateReferance> Response = await Service.SelectSingleAsync(Model);
			return ServiceResponse<CandidateReferanceResponse>.SuccessResponse(Mapper.Map<List<CandidateReferanceResponse>>(Response.Data), "");
		}
	}
}