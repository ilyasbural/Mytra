namespace Mytra.Presentation.Controllers
{
	using Core;
	using Common;
	using Microsoft.AspNetCore.Mvc;
	using Microsoft.AspNetCore.Authorization;

    [ApiController]
    public class JobPostingDetailController : ControllerBase
    {
		//readonly IJobPostingDetailService Service;
		//public JobPostingDetailController(IJobPostingDetailService service) { Service = service; }

		//[HttpPost]
		//[Route("api/jobpostingdetail")]
		//[Produces(typeof(ServiceResponse<JobPostingDetailResponse>))]
		//public async Task<ServiceResponse<JobPostingDetailResponse>> Create([FromBody] JobPostingDetailInsert Model)
		//{
		//	ServiceResponse<JobPostingDetailResponse> Response = await Service.InsertAsync(Model);
		//	return new ServiceResponse<JobPostingDetailResponse>
		//	{
		//		Success = Response.Success,
		//		ResponseData = Response.ResponseData
		//	};
		//}

		//[HttpPut]
		//[Route("api/jobpostingdetail")]
		//[Produces(typeof(ServiceResponse<JobPostingDetailResponse>))]
		//public async Task<ServiceResponse<JobPostingDetailResponse>> Update([FromBody] JobPostingDetailUpdate Model)
		//{
		//	ServiceResponse<JobPostingDetailResponse> Response = await Service.UpdateAsync(Model);
		//	return new ServiceResponse<JobPostingDetailResponse>
		//	{
		//		Success = Response.Success,
		//		ResponseData = Response.ResponseData
		//	};
		//}

		//[HttpDelete]
		//[Route("api/jobpostingdetail")]
		//[Produces(typeof(ServiceResponse<JobPostingDetailResponse>))]
		//public async Task<ServiceResponse<JobPostingDetailResponse>> Delete([FromBody] JobPostingDetailDelete Model)
		//{
		//	ServiceResponse<JobPostingDetailResponse> Response = await Service.DeleteAsync(Model);
		//	return new ServiceResponse<JobPostingDetailResponse>
		//	{
		//		Success = Response.Success,
		//		ResponseData = Response.ResponseData
		//	};
		//}

		//[HttpGet]
		//[Route("api/jobpostingdetail")]
		//[Produces(typeof(ServiceResponse<JobPostingDetailResponse>))]
		//public async Task<ServiceResponse<JobPostingDetailResponse>> Get([FromQuery] JobPostingDetailSelect Model)
		//{
		//	ServiceResponse<JobPostingDetailResponse> Response = await Service.SelectAsync(Model);
		//	return new ServiceResponse<JobPostingDetailResponse>
		//	{
		//		ResponseDataSource = Response.ResponseDataSource
		//	};
		//}

		//[HttpGet]
		//[Route("api/jobpostingdetailsingle")]
		//[Produces(typeof(ServiceResponse<JobPostingDetailResponse>))]
		//public async Task<ServiceResponse<JobPostingDetailResponse>> GetSingle([FromQuery] JobPostingDetailSelectSingle Model)
		//{
		//	ServiceResponse<JobPostingDetailResponse> Response = await Service.SelectSingleAsync(Model);
		//	return new ServiceResponse<JobPostingDetailResponse>
		//	{
		//		ResponseDataSource = Response.ResponseDataSource
		//	};
		//}
	}
}