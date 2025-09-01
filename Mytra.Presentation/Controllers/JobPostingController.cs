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
		[Route("api/jobposting")]
		[Produces(typeof(ServiceResponse<JobPosting>))]
		public async Task<ServiceResponse<JobPosting>> Get([FromQuery] JobPostingSelect Model)
		{
			DataService<JobPosting> Response = await Service.SelectAsync(Model);
			return ServiceResponse<JobPosting>.SuccessResponse(Response.DataList, "");
		}

		[HttpGet]
		[Route("api/jobpostingsingle")]
		[Produces(typeof(ServiceResponse<JobPosting>))]
		public async Task<ServiceResponse<JobPosting>> GetSingle([FromQuery] JobPostingSelectSingle Model)
		{
			DataService<JobPosting> Response = await Service.SelectSingleAsync(Model);
			return ServiceResponse<JobPosting>.SuccessResponse(Response.Data, "");
		}
	}
}