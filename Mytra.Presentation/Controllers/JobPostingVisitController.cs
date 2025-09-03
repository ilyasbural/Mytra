namespace Mytra.Presentation.Controllers
{
	using Core;
	using Common;
	using AutoMapper;
	using Microsoft.AspNetCore.Mvc;
	using Microsoft.AspNetCore.Authorization;

	[ApiController]
    public class JobPostingVisitController : ControllerBase
    {
		readonly IMapper Mapper;
		readonly IJobPostingVisitService Service;
		public JobPostingVisitController(IMapper mapper, IJobPostingVisitService service)
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
		[Route("api/jobpostingvisit")]
		[Produces(typeof(ServiceResponse<JobPostingVisit>))]
		public async Task<ServiceResponse<JobPostingVisit>> Create([FromBody] JobPostingVisitInsert Model)
		{
			DataService<JobPostingVisit> Response = await Service.InsertAsync(Model);
			if (Response.Errors.Count > 0) return ServiceResponse<JobPostingVisit>.FailureResponse(Response.Errors, "");
			if (!Response.Success) return ServiceResponse<JobPostingVisit>.FailureResponse("");
			return ServiceResponse<JobPostingVisit>.SuccessResponse(Response.Data, "");
		}

		[HttpPut]
		[Authorize]
		[Route("api/jobpostingvisit")]
		[Produces(typeof(ServiceResponse<JobPostingVisit>))]
		public async Task<ServiceResponse<JobPostingVisit>> Update([FromBody] JobPostingVisitUpdate Model)
		{
			DataService<JobPostingVisit> Response = await Service.UpdateAsync(Model);
			if (Response.Errors.Count > 0) return ServiceResponse<JobPostingVisit>.FailureResponse(Response.Errors, "");
			if (!Response.Success) return ServiceResponse<JobPostingVisit>.FailureResponse("");
			return ServiceResponse<JobPostingVisit>.SuccessResponse(Response.Data, "");
		}

		[HttpDelete]
		[Authorize]
		[Route("api/jobpostingvisit")]
		[Produces(typeof(ServiceResponse<JobPostingVisit>))]
		public async Task<ServiceResponse<JobPostingVisit>> Delete([FromBody] JobPostingVisitDelete Model)
		{
			DataService<JobPostingVisit> Response = await Service.DeleteAsync(Model);
			if (Response.Errors.Count > 0) return ServiceResponse<JobPostingVisit>.FailureResponse(Response.Errors, "");
			if (!Response.Success) return ServiceResponse<JobPostingVisit>.FailureResponse("");
			return ServiceResponse<JobPostingVisit>.SuccessResponse(Response.Data, "");
		}

		[HttpGet]
		[Authorize]
		[Route("api/jobpostingvisit")]
		[Produces(typeof(ServiceResponse<JobPostingVisitResponse>))]
		public async Task<ServiceResponse<JobPostingVisitResponse>> Get([FromQuery] JobPostingVisitSelect Model)
		{
			DataService<JobPostingVisit> Response = await Service.SelectAsync(Model);
			return ServiceResponse<JobPostingVisitResponse>.SuccessResponse(Mapper.Map<List<JobPostingVisitResponse>>(Response.DataList), "");
		}

		[HttpGet]
		[Authorize]
		[Route("api/jobpostingvisitsingle")]
		[Produces(typeof(ServiceResponse<JobPostingVisitResponse>))]
		public async Task<ServiceResponse<JobPostingVisitResponse>> GetSingle([FromQuery] JobPostingVisitSelectSingle Model)
		{
			DataService<JobPostingVisit> Response = await Service.SelectSingleAsync(Model);
			return ServiceResponse<JobPostingVisitResponse>.SuccessResponse(Mapper.Map<List<JobPostingVisitResponse>>(Response.Data), "");
		}
	}
}