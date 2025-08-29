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
		[Authorize]
		[Route("api/jobpostingapply")]
		[Produces(typeof(ServiceResponse<JobPostingApplyResponse>))]
		public async Task<ServiceResponse<JobPostingApplyResponse>> Create([FromBody] JobPostingApplyInsert Model)
		{
			ServiceResponse<JobPostingApplyResponse> Response = await Service.InsertAsync(Model);
			return new ServiceResponse<JobPostingApplyResponse>
			{
				ResponseData = Response.ResponseData
			};
		}

		[HttpPut]
		[Authorize]
		[Route("api/jobpostingapply")]
		[Produces(typeof(ServiceResponse<JobPostingApplyResponse>))]
		public async Task<ServiceResponse<JobPostingApplyResponse>> Update([FromBody] JobPostingApplyUpdate Model)
		{
			ServiceResponse<JobPostingApplyResponse> Response = await Service.UpdateAsync(Model);
			return new ServiceResponse<JobPostingApplyResponse>
			{
				ResponseData = Response.ResponseData
			};
		}

		[HttpDelete]
		[Authorize]
		[Route("api/jobpostingapply")]
		[Produces(typeof(ServiceResponse<JobPostingApplyResponse>))]
		public async Task<ServiceResponse<JobPostingApplyResponse>> Delete([FromBody] JobPostingApplyDelete Model)
		{
			ServiceResponse<JobPostingApplyResponse> Response = await Service.DeleteAsync(Model);
			return new ServiceResponse<JobPostingApplyResponse>
			{
				ResponseData = Response.ResponseData
			};
		}
	}
}