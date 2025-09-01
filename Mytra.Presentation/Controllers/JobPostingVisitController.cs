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
		[Produces(typeof(ServiceResponse<JobPostingVisit>))]
		public async Task<ServiceResponse<JobPostingVisit>> Create([FromBody] JobPostingVisitInsert Model)
		{
			DataService<JobPostingVisit> Response = await Service.InsertAsync(Model);
			if (Response.Errors.Count > 0) return ServiceResponse<JobPostingVisit>.FailureResponse(Response.Errors, "");
			if (!Response.Success) return ServiceResponse<JobPostingVisit>.FailureResponse("");
			return ServiceResponse<JobPostingVisit>.SuccessResponse(Response.Data, "");
		}

		//[HttpPut]
		//[Route("api/jobpostingvisit")]
		//[Produces(typeof(ServiceResponse<JobPostingVisitResponse>))]
		//public async Task<ServiceResponse<JobPostingVisitResponse>> Update([FromBody] JobPostingVisitUpdate Model)
		//{
		//	ServiceResponse<JobPostingVisitResponse> Response = await Service.UpdateAsync(Model);
		//	return new ServiceResponse<JobPostingVisitResponse>
		//	{
		//		Success = Response.Success,
		//		ResponseData = Response.ResponseData
		//	};
		//}

		//[HttpDelete]
		//[Route("api/jobpostingvisit")]
		//[Produces(typeof(ServiceResponse<JobPostingVisitResponse>))]
		//public async Task<ServiceResponse<JobPostingVisitResponse>> Delete([FromBody] JobPostingVisitDelete Model)
		//{
		//	ServiceResponse<JobPostingVisitResponse> Response = await Service.DeleteAsync(Model);
		//	return new ServiceResponse<JobPostingVisitResponse>
		//	{
		//		Success = Response.Success,
		//		ResponseData = Response.ResponseData
		//	};
		//}

		[HttpGet]
		[Route("api/jobpostingvisit")]
		[Produces(typeof(ServiceResponse<JobPostingVisit>))]
		public async Task<ServiceResponse<JobPostingVisit>> Get([FromQuery] JobPostingVisitSelect Model)
		{
			DataService<JobPostingVisit> Response = await Service.SelectAsync(Model);
			return ServiceResponse<JobPostingVisit>.SuccessResponse(Response.DataList, "jobpostingvisit list");
		}

		//[HttpGet]
		//[Route("api/jobpostingvisitsingle")]
		//[Produces(typeof(ServiceResponse<JobPostingVisitResponse>))]
		//public async Task<ServiceResponse<JobPostingVisitResponse>> GetSingle([FromQuery] JobPostingVisitSelectSingle Model)
		//{
		//	ServiceResponse<JobPostingVisitResponse> Response = await Service.SelectSingleAsync(Model);
		//	return new ServiceResponse<JobPostingVisitResponse>
		//	{
		//		ResponseDataSource = Response.ResponseDataSource
		//	};
		//}
	}
}