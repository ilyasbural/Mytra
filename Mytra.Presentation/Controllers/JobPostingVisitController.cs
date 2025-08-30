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
		[Route("api/jobpostingvisit")]
		[Produces(typeof(ServiceResponse<JobPostingVisitResponse>))]
		public async Task<ServiceResponse<JobPostingVisitResponse>> Create([FromBody] JobPostingVisitInsert Model)
		{
			ServiceResponse<JobPostingVisitResponse> Response = await Service.InsertAsync(Model);
			return new ServiceResponse<JobPostingVisitResponse>
			{
				Success = Response.Success,
				ResponseData = Response.ResponseData
			};
		}

		[HttpPut]
		[Route("api/jobpostingvisit")]
		[Produces(typeof(ServiceResponse<JobPostingVisitResponse>))]
		public async Task<ServiceResponse<JobPostingVisitResponse>> Update([FromBody] JobPostingVisitUpdate Model)
		{
			ServiceResponse<JobPostingVisitResponse> Response = await Service.UpdateAsync(Model);
			return new ServiceResponse<JobPostingVisitResponse>
			{
				Success = Response.Success,
				ResponseData = Response.ResponseData
			};
		}

		[HttpDelete]
		[Route("api/jobpostingvisit")]
		[Produces(typeof(ServiceResponse<JobPostingVisitResponse>))]
		public async Task<ServiceResponse<JobPostingVisitResponse>> Delete([FromBody] JobPostingVisitDelete Model)
		{
			ServiceResponse<JobPostingVisitResponse> Response = await Service.DeleteAsync(Model);
			return new ServiceResponse<JobPostingVisitResponse>
			{
				Success = Response.Success,
				ResponseData = Response.ResponseData
			};
		}

		[HttpGet]
		[Authorize]
		[Route("api/jobpostingvisit")]
		[Produces(typeof(ServiceResponse<JobPostingVisitResponse>))]
		public async Task<ServiceResponse<JobPostingVisitResponse>> Get([FromQuery] JobPostingVisitSelect Model)
		{
			ServiceResponse<JobPostingVisitResponse> Response = await Service.SelectAsync(Model);
			return new ServiceResponse<JobPostingVisitResponse>
			{
				ResponseDataSource = Response.ResponseDataSource
			};
		}

		[HttpGet]
		[Authorize]
		[Route("api/jobpostingvisitsingle")]
		[Produces(typeof(ServiceResponse<JobPostingVisitResponse>))]
		public async Task<ServiceResponse<JobPostingVisitResponse>> GetSingle([FromQuery] JobPostingVisitSelectSingle Model)
		{
			ServiceResponse<JobPostingVisitResponse> Response = await Service.SelectSingleAsync(Model);
			return new ServiceResponse<JobPostingVisitResponse>
			{
				ResponseDataSource = Response.ResponseDataSource
			};
		}
	}
}