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
		[Produces(typeof(ServiceResponse<JobPostingResponse>))]
		public async Task<ServiceResponse<JobPostingResponse>> Create([FromBody] JobPostingInsert Model)
		{
			ServiceResponse<JobPostingResponse> Response = await Service.InsertAsync(Model);
			return new ServiceResponse<JobPostingResponse>
			{
				Success = Response.Success,
				ResponseData = Response.ResponseData
			};
		}

		[HttpPut]
		[Route("api/jobposting")]
		[Produces(typeof(ServiceResponse<JobPostingResponse>))]
		public async Task<ServiceResponse<JobPostingResponse>> Update([FromBody] JobPostingUpdate Model)
		{
			ServiceResponse<JobPostingResponse> Response = await Service.UpdateAsync(Model);
			return new ServiceResponse<JobPostingResponse>
			{
				Success = Response.Success,
				ResponseData = Response.ResponseData
			};
		}

		[HttpDelete]
		[Route("api/jobposting")]
		[Produces(typeof(ServiceResponse<JobPostingResponse>))]
		public async Task<ServiceResponse<JobPostingResponse>> Delete([FromBody] JobPostingDelete Model)
		{
			ServiceResponse<JobPostingResponse> Response = await Service.DeleteAsync(Model);
			return new ServiceResponse<JobPostingResponse>
			{
				Success = Response.Success,
				ResponseData = Response.ResponseData
			};
		}

		[HttpGet]
		[Authorize]
		[Route("api/jobposting")]
		[Produces(typeof(ServiceResponse<JobPostingResponse>))]
		public async Task<ServiceResponse<JobPostingResponse>> Get([FromQuery] JobPostingSelect Model)
		{
			ServiceResponse<JobPostingResponse> Response = await Service.SelectAsync(Model);
			return new ServiceResponse<JobPostingResponse>
			{
				ResponseDataSource = Response.ResponseDataSource
			};
		}

		[HttpGet]
		[Authorize]
		[Route("api/jobpostingsingle")]
		[Produces(typeof(ServiceResponse<JobPostingResponse>))]
		public async Task<ServiceResponse<JobPostingResponse>> GetSingle([FromQuery] JobPostingSelectSingle Model)
		{
			ServiceResponse<JobPostingResponse> Response = await Service.SelectSingleAsync(Model);
			return new ServiceResponse<JobPostingResponse>
			{
				ResponseDataSource = Response.ResponseDataSource
			};
		}
	}
}