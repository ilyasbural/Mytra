namespace Mytra.Presentation.Controllers
{
	using Core;
	using Common;
	using Microsoft.AspNetCore.Mvc;
	using Microsoft.AspNetCore.Authorization;

    [ApiController]
    public class JobPostingDetailController : ControllerBase
    {
		readonly IJobPostingDetailService Service;
		public JobPostingDetailController(IJobPostingDetailService service) { Service = service; }

		[HttpPost]
		[Authorize]
		[Route("api/jobpostingdetail")]
		[Produces(typeof(ServiceResponse<JobPostingDetailResponse>))]
		public async Task<ServiceResponse<JobPostingDetailResponse>> Create([FromBody] JobPostingDetailInsert Model)
		{
			ServiceResponse<JobPostingDetailResponse> Response = await Service.InsertAsync(Model);
			return new ServiceResponse<JobPostingDetailResponse>
			{
				ResponseData = Response.ResponseData
			};
		}
	}
}