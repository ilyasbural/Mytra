namespace Mytra.Presentation.Controllers
{
	using Core;
	using Common;
	using Microsoft.AspNetCore.Mvc;
	using Microsoft.AspNetCore.Authorization;

    [ApiController]
    public class JobPostingApplyController : ControllerBase
    {
		readonly IJobPostingApplyService Service;
		public JobPostingApplyController(IJobPostingApplyService service) { Service = service; }

		[HttpPost]
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
		[Route("api/jobpostingapply")]
		[Produces(typeof(ServiceResponse<JobPostingApply>))]
		public async Task<ServiceResponse<JobPostingApply>> Get([FromQuery] JobPostingApplySelect Model)
		{
			DataService<JobPostingApply> Response = await Service.SelectAsync(Model);
			return ServiceResponse<JobPostingApply>.SuccessResponse(Response.DataList, "");
		}

		[HttpGet]
		[Route("api/jobpostingapplysingle")]
		[Produces(typeof(ServiceResponse<JobPostingApply>))]
		public async Task<ServiceResponse<JobPostingApply>> GetSingle([FromQuery] JobPostingApplySelectSingle Model)
		{
			DataService<JobPostingApply> Response = await Service.SelectSingleAsync(Model);
			return ServiceResponse<JobPostingApply>.SuccessResponse(Response.Data, "");
		}
	}
}