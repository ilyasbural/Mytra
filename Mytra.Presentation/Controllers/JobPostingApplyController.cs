namespace Mytra.Presentation.Controllers
{
	using Core;
	using Common;
	using AutoMapper;
	using Microsoft.AspNetCore.Mvc;
	using Microsoft.AspNetCore.Authorization;

	[ApiController]
    public class JobPostingApplyController : ControllerBase
    {
		readonly IMapper Mapper;
		readonly IJobPostingApplyService Service;
		public JobPostingApplyController(IMapper mapper, IJobPostingApplyService service)
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
		[Route("api/jobpostingapply")]
		[Produces(typeof(ServiceResponse<JobPostingApply>))]
		public async Task<ServiceResponse<JobPostingApply>> Create([FromBody] JobPostingApplyInsert Model)
		{
			DataService<JobPostingApply> Response = await Service.InsertAsync(Model);
			if (Response.Errors.Count > 0) return ServiceResponse<JobPostingApply>.FailureResponse(Response.Errors, "");
			if (!Response.Success) return ServiceResponse<JobPostingApply>.FailureResponse("");
			return ServiceResponse<JobPostingApply>.SuccessResponse(Response.Data, "");
		}

		[HttpPut]
		[Authorize]
		[Route("api/jobpostingapply")]
		[Produces(typeof(ServiceResponse<JobPostingApply>))]
		public async Task<ServiceResponse<JobPostingApply>> Update([FromBody] JobPostingApplyUpdate Model)
		{
			DataService<JobPostingApply> Response = await Service.UpdateAsync(Model);
			if (Response.Errors.Count > 0) return ServiceResponse<JobPostingApply>.FailureResponse(Response.Errors, "");
			if (!Response.Success) return ServiceResponse<JobPostingApply>.FailureResponse("");
			return ServiceResponse<JobPostingApply>.SuccessResponse(Response.Data, "");
		}

		[HttpDelete]
		[Authorize]
		[Route("api/jobpostingapply")]
		[Produces(typeof(ServiceResponse<JobPostingApply>))]
		public async Task<ServiceResponse<JobPostingApply>> Delete([FromBody] JobPostingApplyDelete Model)
		{
			DataService<JobPostingApply> Response = await Service.DeleteAsync(Model);
			if (Response.Errors.Count > 0) return ServiceResponse<JobPostingApply>.FailureResponse(Response.Errors, "");
			if (!Response.Success) return ServiceResponse<JobPostingApply>.FailureResponse("");
			return ServiceResponse<JobPostingApply>.SuccessResponse(Response.Data, "");
		}

		[HttpGet]
		[Authorize]
		[Route("api/jobpostingapply")]
		[Produces(typeof(ServiceResponse<JobPostingApplyResponse>))]
		public async Task<ServiceResponse<JobPostingApplyResponse>> Get([FromQuery] JobPostingApplySelect Model)
		{
			DataService<JobPostingApply> Response = await Service.SelectAsync(Model);
			return ServiceResponse<JobPostingApplyResponse>.SuccessResponse(Mapper.Map<List<JobPostingApplyResponse>>(Response.DataList), "");
		}

		[HttpGet]
		[Authorize]
		[Route("api/jobpostingapplysingle")]
		[Produces(typeof(ServiceResponse<JobPostingApplyResponse>))]
		public async Task<ServiceResponse<JobPostingApplyResponse>> GetSingle([FromQuery] JobPostingApplySelectSingle Model)
		{
			DataService<JobPostingApply> Response = await Service.SelectSingleAsync(Model);
			return ServiceResponse<JobPostingApplyResponse>.SuccessResponse(Mapper.Map<List<JobPostingApplyResponse>>(Response.Data), "");
		}
	}
}