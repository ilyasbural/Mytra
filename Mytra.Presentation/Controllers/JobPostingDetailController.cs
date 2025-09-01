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

		[HttpPut]
		[Route("api/jobpostingdetail")]
		[Produces(typeof(ServiceResponse<JobPostingDetail>))]
		public async Task<ServiceResponse<JobPostingDetail>> Update([FromBody] JobPostingDetailUpdate Model)
		{
			DataService<JobPostingDetail> Response = await Service.UpdateAsync(Model);
			if (Response.Errors.Count > 0) return ServiceResponse<JobPostingDetail>.FailureResponse(Response.Errors, "");
			if (!Response.Success) return ServiceResponse<JobPostingDetail>.FailureResponse("");
			return ServiceResponse<JobPostingDetail>.SuccessResponse(Response.Data, "");
		}

		[HttpDelete]
		[Route("api/jobpostingdetail")]
		[Produces(typeof(ServiceResponse<JobPostingDetail>))]
		public async Task<ServiceResponse<JobPostingDetail>> Delete([FromBody] JobPostingDetailDelete Model)
		{
			DataService<JobPostingDetail> Response = await Service.DeleteAsync(Model);
			if (Response.Errors.Count > 0) return ServiceResponse<JobPostingDetail>.FailureResponse(Response.Errors, "");
			if (!Response.Success) return ServiceResponse<JobPostingDetail>.FailureResponse("");
			return ServiceResponse<JobPostingDetail>.SuccessResponse(Response.Data, "");
		}

		[HttpGet]
		[Route("api/jobpostingdetail")]
		[Produces(typeof(ServiceResponse<JobPostingDetail>))]
		public async Task<ServiceResponse<JobPostingDetail>> Get([FromQuery] JobPostingDetailSelect Model)
		{
			DataService<JobPostingDetail> Response = await Service.SelectAsync(Model);
			return ServiceResponse<JobPostingDetail>.SuccessResponse(Response.DataList, "");
		}

		[HttpGet]
		[Route("api/jobpostingdetailsingle")]
		[Produces(typeof(ServiceResponse<JobPostingDetail>))]
		public async Task<ServiceResponse<JobPostingDetail>> GetSingle([FromQuery] JobPostingDetailSelectSingle Model)
		{
			DataService<JobPostingDetail> Response = await Service.SelectSingleAsync(Model);
			return ServiceResponse<JobPostingDetail>.SuccessResponse(Response.Data, "");
		}
	}
}