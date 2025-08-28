namespace Mytra.Presentation.Controllers
{
	using Core;
	using Common;
	using Microsoft.AspNetCore.Mvc;
	using Microsoft.AspNetCore.Authorization;

    [ApiController]
    public class JobPostingController : ControllerBase
    {
		readonly IJobPostingService Service;
		public JobPostingController(IJobPostingService service) { Service = service; }

		[HttpPost]
		[Authorize]
		[Route("api/jobposting")]
		[Produces(typeof(ServiceResponse<JobPostingResponse>))]
		public async Task<ServiceResponse<JobPostingResponse>> Create([FromBody] JobPostingInsert Model)
		{
			ServiceResponse<JobPostingResponse> Response = await Service.InsertAsync(Model);
			return new ServiceResponse<JobPostingResponse>
			{
				ResponseData = Response.ResponseData
			};
		}
	}
}