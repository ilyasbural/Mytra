namespace Mytra.Presentation.Controllers
{
	using Core;
	using Common;
	using AutoMapper;
	using Microsoft.AspNetCore.Mvc;
	using Microsoft.AspNetCore.Authorization;

	[ApiController]
    public class JobPostingController : ControllerBase
    {
		readonly IMapper Mapper;
		readonly IJobPostingService Service;
		public JobPostingController(IMapper mapper, IJobPostingService service)
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
		[Route("api/jobposting")]
		[Produces(typeof(ServiceResponse<JobPosting>))]
		public async Task<ServiceResponse<JobPosting>> Create([FromBody] JobPostingInsert Model)
		{
			DataService<JobPosting> Response = await Service.InsertAsync(Model);
			if (Response.Errors.Count > 0) return ServiceResponse<JobPosting>.FailureResponse(Response.Errors, "");
			if (!Response.Success) return ServiceResponse<JobPosting>.FailureResponse("");
			return ServiceResponse<JobPosting>.SuccessResponse(Response.Data, "");
		}

		[HttpPut]
		[Authorize]
		[Route("api/jobposting")]
		[Produces(typeof(ServiceResponse<JobPosting>))]
		public async Task<ServiceResponse<JobPosting>> Update([FromBody] JobPostingUpdate Model)
		{
			DataService<JobPosting> Response = await Service.UpdateAsync(Model);
			if (Response.Errors.Count > 0) return ServiceResponse<JobPosting>.FailureResponse(Response.Errors, "");
			if (!Response.Success) return ServiceResponse<JobPosting>.FailureResponse("");
			return ServiceResponse<JobPosting>.SuccessResponse(Response.Data, "");
		}

		[HttpDelete]
		[Authorize]
		[Route("api/jobposting")]
		[Produces(typeof(ServiceResponse<JobPosting>))]
		public async Task<ServiceResponse<JobPosting>> Delete([FromBody] JobPostingDelete Model)
		{
			DataService<JobPosting> Response = await Service.DeleteAsync(Model);
			if (Response.Errors.Count > 0) return ServiceResponse<JobPosting>.FailureResponse(Response.Errors, "");
			if (!Response.Success) return ServiceResponse<JobPosting>.FailureResponse("");
			return ServiceResponse<JobPosting>.SuccessResponse(Response.Data, "");
		}

		[HttpGet]
		[Authorize]
		[Route("api/jobposting")]
		[Produces(typeof(ServiceResponse<JobPostingResponse>))]
		public async Task<ServiceResponse<JobPostingResponse>> Get([FromQuery] JobPostingSelect Model)
		{
			DataService<JobPosting> Response = await Service.SelectAsync(Model);
			return ServiceResponse<JobPostingResponse>.SuccessResponse(Mapper.Map<List<JobPostingResponse>>(Response.DataList), "");
		}

		[HttpGet]
		[Authorize]
		[Route("api/jobpostingsingle")]
		[Produces(typeof(ServiceResponse<JobPostingResponse>))]
		public async Task<ServiceResponse<JobPostingResponse>> GetSingle([FromQuery] JobPostingSelectSingle Model)
		{
			DataService<JobPosting> Response = await Service.SelectSingleAsync(Model);
			return ServiceResponse<JobPostingResponse>.SuccessResponse(Mapper.Map<List<JobPostingResponse>>(Response.Data), "");
		}
	}
}