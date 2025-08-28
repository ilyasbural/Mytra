namespace Mytra.Presentation.Controllers
{
	using Core;
	using Common;
	using Microsoft.AspNetCore.Mvc;
	using Microsoft.AspNetCore.Authorization;

    [ApiController]
    public class JobPostingVisitController : ControllerBase
    {
		readonly IJobPostingVisitService Service;
		public JobPostingVisitController(IJobPostingVisitService service) { Service = service; }

		[HttpPost]
		[Authorize]
		[Route("api/jobpostingvisit")]
		[Produces(typeof(ServiceResponse<JobPostingVisitResponse>))]
		public async Task<ServiceResponse<JobPostingVisitResponse>> Create([FromBody] JobPostingVisitInsert Model)
		{
			ServiceResponse<JobPostingVisitResponse> Response = await Service.InsertAsync(Model);
			return new ServiceResponse<JobPostingVisitResponse>
			{
				ResponseData = Response.ResponseData
			};
		}

		[HttpPut]
		[Authorize]
		[Route("api/jobpostingvisit")]
		[Produces(typeof(ServiceResponse<JobPostingVisitResponse>))]
		public async Task<ServiceResponse<JobPostingVisitResponse>> Update([FromBody] JobPostingVisitUpdate Model)
		{
			ServiceResponse<JobPostingVisitResponse> Response = await Service.UpdateAsync(Model);
			return new ServiceResponse<JobPostingVisitResponse>
			{
				ResponseData = Response.ResponseData
			};
		}
	}
}