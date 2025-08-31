namespace Mytra.Presentation.Controllers
{
	using Core;
	using Common;
	using Microsoft.AspNetCore.Mvc;
	using Microsoft.AspNetCore.Authorization;

    [ApiController]
    public class JobPostingApplyController : ControllerBase
    {
		//readonly IJobPostingApplyService Service;
		//public JobPostingApplyController(IJobPostingApplyService service) { Service = service; }

		//[HttpPost]
		//[Route("api/jobpostingapply")]
		//[Produces(typeof(ServiceResponse<JobPostingApplyResponse>))]
		//public async Task<ServiceResponse<JobPostingApplyResponse>> Create([FromBody] JobPostingApplyInsert Model)
		//{
		//	ServiceResponse<JobPostingApplyResponse> Response = await Service.InsertAsync(Model);
		//	return new ServiceResponse<JobPostingApplyResponse>
		//	{
		//		Success = Response.Success,
		//		ResponseData = Response.ResponseData
		//	};
		//}

		//[HttpPut]
		//[Route("api/jobpostingapply")]
		//[Produces(typeof(ServiceResponse<JobPostingApplyResponse>))]
		//public async Task<ServiceResponse<JobPostingApplyResponse>> Update([FromBody] JobPostingApplyUpdate Model)
		//{
		//	ServiceResponse<JobPostingApplyResponse> Response = await Service.UpdateAsync(Model);
		//	return new ServiceResponse<JobPostingApplyResponse>
		//	{
		//		Success = Response.Success,
		//		ResponseData = Response.ResponseData
		//	};
		//}

		//[HttpDelete]
		//[Route("api/jobpostingapply")]
		//[Produces(typeof(ServiceResponse<JobPostingApplyResponse>))]
		//public async Task<ServiceResponse<JobPostingApplyResponse>> Delete([FromBody] JobPostingApplyDelete Model)
		//{
		//	ServiceResponse<JobPostingApplyResponse> Response = await Service.DeleteAsync(Model);
		//	return new ServiceResponse<JobPostingApplyResponse>
		//	{
		//		Success = Response.Success,
		//		ResponseData = Response.ResponseData
		//	};
		//}

		//[HttpGet]
		//[Route("api/jobpostingapply")]
		//[Produces(typeof(ServiceResponse<JobPostingApplyResponse>))]
		//public async Task<ServiceResponse<JobPostingApplyResponse>> Get([FromQuery] JobPostingApplySelect Model)
		//{
		//	ServiceResponse<JobPostingApplyResponse> Response = await Service.SelectAsync(Model);
		//	return new ServiceResponse<JobPostingApplyResponse>
		//	{
		//		ResponseDataSource = Response.ResponseDataSource
		//	};
		//}

		//[HttpGet]
		//[Route("api/jobpostingapplysingle")]
		//[Produces(typeof(ServiceResponse<JobPostingApplyResponse>))]
		//public async Task<ServiceResponse<JobPostingApplyResponse>> GetSingle([FromQuery] JobPostingApplySelectSingle Model)
		//{
		//	ServiceResponse<JobPostingApplyResponse> Response = await Service.SelectSingleAsync(Model);
		//	return new ServiceResponse<JobPostingApplyResponse>
		//	{
		//		ResponseDataSource = Response.ResponseDataSource
		//	};
		//}
	}
}