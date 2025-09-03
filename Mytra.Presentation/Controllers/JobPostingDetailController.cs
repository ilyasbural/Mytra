namespace Mytra.Presentation.Controllers
{
	using Core;
	using Common;
	using AutoMapper;
	using Microsoft.AspNetCore.Mvc;
	using Microsoft.AspNetCore.Authorization;

	[ApiController]
    public class JobPostingDetailController : ControllerBase
    {
		readonly IMapper Mapper;
		readonly IJobPostingDetailService Service;
		public JobPostingDetailController(IMapper mapper, IJobPostingDetailService service)
		{
			Mapper = mapper;
			Service = service;
		}

		[HttpPost]
		[Authorize]
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
		[Authorize]
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
		[Authorize]
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
		[Authorize]
		[Route("api/jobpostingdetail")]
		[Produces(typeof(ServiceResponse<JobPostingDetailResponse>))]
		public async Task<ServiceResponse<JobPostingDetailResponse>> Get([FromQuery] JobPostingDetailSelect Model)
		{
			DataService<JobPostingDetail> Response = await Service.SelectAsync(Model);
			return ServiceResponse<JobPostingDetailResponse>.SuccessResponse(Mapper.Map<List<JobPostingDetailResponse>>(Response.DataList), "");
		}

		[HttpGet]
		[Authorize]
		[Route("api/jobpostingdetailsingle")]
		[Produces(typeof(ServiceResponse<JobPostingDetailResponse>))]
		public async Task<ServiceResponse<JobPostingDetailResponse>> GetSingle([FromQuery] JobPostingDetailSelectSingle Model)
		{
			DataService<JobPostingDetail> Response = await Service.SelectSingleAsync(Model);
			return ServiceResponse<JobPostingDetailResponse>.SuccessResponse(Mapper.Map<List<JobPostingDetailResponse>>(Response.Data), "");
		}
	}
}