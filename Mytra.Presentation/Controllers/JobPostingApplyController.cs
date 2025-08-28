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
		[Produces(typeof(ServiceResponse<JobPostingApplyResponse>))]
		public async Task<ServiceResponse<JobPostingApplyResponse>> Create([FromBody] JobPostingApplyInsert Model)
		{
			ServiceResponse<JobPostingApplyResponse> Response = await Service.InsertAsync(Model);
			return new ServiceResponse<JobPostingApplyResponse>
			{
				ResponseData = Response.ResponseData
			};
		}
	}
}