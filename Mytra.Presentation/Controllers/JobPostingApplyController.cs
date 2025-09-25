namespace Mytra.Presentation.Controllers
{
	using Core;
	using Utilize;
	using AutoMapper;
	using Microsoft.AspNetCore.Mvc;

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
		[Route("api/jobpostingapply")]
		[Produces(typeof(ServiceResponse<JobPostingApplyResponse>))]
		public async Task<ServiceResponse<JobPostingApplyResponse>> Create([FromBody] JobPostingApplyInsert Model)
		{
			DataService<JobPostingApply> Response = await Service.InsertAsync(Model);
			if (Response.Errors.Count > 0) return ServiceResponse<JobPostingApplyResponse>.FailureResponse(Response.Errors, "");
			if (!Response.Success) return ServiceResponse<JobPostingApplyResponse>.FailureResponse("");
			return ServiceResponse<JobPostingApplyResponse>.SuccessResponse(Mapper.Map<JobPostingApplyResponse>(Response.Data), "");
		}

		[HttpPut]
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
		[Route("api/jobpostingapply/{id}")]
		[Produces(typeof(ServiceResponse<JobPostingApply>))]
		public async Task<ServiceResponse<JobPostingApply>> Delete(Guid Id)
		{
			DataService<JobPostingApply> Response = await Service.DeleteAsync(Id);
			if (Response.Errors.Count > 0) return ServiceResponse<JobPostingApply>.FailureResponse(Response.Errors, "");
			if (!Response.Success) return ServiceResponse<JobPostingApply>.FailureResponse("");
			return ServiceResponse<JobPostingApply>.SuccessResponse(Response.Data, "");
		}

		[HttpGet]
		[Route("api/jobpostingapply")]
		[Produces(typeof(ServiceResponse<JobPostingApplyResponse>))]
		public async Task<ServiceResponse<JobPostingApplyResponse>> Get([FromQuery] JobPostingApplySelect Model)
		{
			DataService<JobPostingApply> Response = await Service.SelectAsync(Model);
			return ServiceResponse<JobPostingApplyResponse>.SuccessResponse(Mapper.Map<List<JobPostingApplyResponse>>(Response.DataList), "");
		}

		[HttpGet]
		[Route("api/jobpostingapplysingle")]
		[Produces(typeof(ServiceResponse<JobPostingApplyResponse>))]
		public async Task<ServiceResponse<JobPostingApplyResponse>> GetSingle([FromQuery] JobPostingApplySelectSingle Model)
		{
			DataService<JobPostingApply> Response = await Service.SelectSingleAsync(Model);
			return ServiceResponse<JobPostingApplyResponse>.SuccessResponse(Mapper.Map<JobPostingApplyResponse>(Response.Data), "");
		}
	}
}