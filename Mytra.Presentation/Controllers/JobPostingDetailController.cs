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
		[Route("api/jobpostingdetail")]
		[Produces(typeof(ServiceResponse<JobPostingDetail>))]
		public async Task<ServiceResponse<JobPostingDetail>> Create([FromBody] JobPostingDetailInsert Model)
		{
			DataService<JobPostingDetail> Response = await Service.InsertAsync(Model);
			if (Response.Errors.Count > 0) return ServiceResponse<JobPostingDetail>.FailureResponse(Response.Errors, "");
			if (!Response.Success) return ServiceResponse<JobPostingDetail>.FailureResponse("");
			return ServiceResponse<JobPostingDetail>.SuccessResponse(Response.Data, "");
		}

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

		[HttpGet]
		[Route("api/jobpostingdetail")]
		[Produces(typeof(ServiceResponse<JobPostingDetail>))]
		public async Task<ServiceResponse<JobPostingDetail>> Get([FromQuery] JobPostingDetailSelect Model)
		{
			DataService<JobPostingDetail> Response = await Service.SelectAsync(Model);
			return ServiceResponse<JobPostingDetail>.SuccessResponse(Response.DataList, "jobpostingdetail list");
		}

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