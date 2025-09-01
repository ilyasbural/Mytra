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

		//[HttpPut]
		//[Route("api/jobposting")]
		//[Produces(typeof(ServiceResponse<JobPostingResponse>))]
		//public async Task<ServiceResponse<JobPostingResponse>> Update([FromBody] JobPostingUpdate Model)
		//{
		//	ServiceResponse<JobPostingResponse> Response = await Service.UpdateAsync(Model);
		//	return new ServiceResponse<JobPostingResponse>
		//	{
		//		Success = Response.Success,
		//		ResponseData = Response.ResponseData
		//	};
		//}

		//[HttpDelete]
		//[Route("api/jobposting")]
		//[Produces(typeof(ServiceResponse<JobPostingResponse>))]
		//public async Task<ServiceResponse<JobPostingResponse>> Delete([FromBody] JobPostingDelete Model)
		//{
		//	ServiceResponse<JobPostingResponse> Response = await Service.DeleteAsync(Model);
		//	return new ServiceResponse<JobPostingResponse>
		//	{
		//		Success = Response.Success,
		//		ResponseData = Response.ResponseData
		//	};
		//}

		[HttpGet]
		[Route("api/jobposting")]
		[Produces(typeof(ServiceResponse<JobPosting>))]
		public async Task<ServiceResponse<JobPosting>> Get([FromQuery] JobPostingSelect Model)
		{
			DataService<JobPosting> Response = await Service.SelectAsync(Model);
			return ServiceResponse<JobPosting>.SuccessResponse(Response.DataList, "jobposting list");
		}

		//[HttpGet]
		//[Route("api/jobpostingsingle")]
		//[Produces(typeof(ServiceResponse<JobPostingResponse>))]
		//public async Task<ServiceResponse<JobPostingResponse>> GetSingle([FromQuery] JobPostingSelectSingle Model)
		//{
		//	ServiceResponse<JobPostingResponse> Response = await Service.SelectSingleAsync(Model);
		//	return new ServiceResponse<JobPostingResponse>
		//	{
		//		ResponseDataSource = Response.ResponseDataSource
		//	};
		//}
	}
}