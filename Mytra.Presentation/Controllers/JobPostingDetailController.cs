namespace Mytra.Presentation.Controllers
{
	using Core;
	using Utilize;
	using AutoMapper;
	using Microsoft.AspNetCore.Mvc;

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
		[Route("api/jobpostingdetail")]
		[Produces(typeof(ServiceResponse<JobPostingDetailResponse>))]
		public async Task<ServiceResponse<JobPostingDetailResponse>> Create([FromBody] JobPostingDetailInsert Model)
		{
			DataService<JobPostingDetail> Response = await Service.InsertAsync(Model);
			if (Response.Errors.Count > 0) return ServiceResponse<JobPostingDetailResponse>.FailureResponse(Response.Errors, "");
			if (!Response.Success) return ServiceResponse<JobPostingDetailResponse>.FailureResponse("");
			return ServiceResponse<JobPostingDetailResponse>.SuccessResponse(Mapper.Map<JobPostingDetailResponse>(Response.Data), "");
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
		[Route("api/jobpostingdetail/{id}")]
		[Produces(typeof(ServiceResponse<JobPostingDetail>))]
		public async Task<ServiceResponse<JobPostingDetail>> Delete(Guid Id)
		{
			DataService<JobPostingDetail> Response = await Service.DeleteAsync(Id);
			if (Response.Errors.Count > 0) return ServiceResponse<JobPostingDetail>.FailureResponse(Response.Errors, "");
			if (!Response.Success) return ServiceResponse<JobPostingDetail>.FailureResponse("");
			return ServiceResponse<JobPostingDetail>.SuccessResponse(Response.Data, "");
		}

		[HttpGet]
		[Route("api/jobpostingdetail")]
		[Produces(typeof(ServiceResponse<JobPostingDetailResponse>))]
		public async Task<ServiceResponse<JobPostingDetailResponse>> Get([FromQuery] JobPostingDetailSelect Model)
		{
			DataService<JobPostingDetail> Response = await Service.SelectAsync(Model);
			return ServiceResponse<JobPostingDetailResponse>.SuccessResponse(Mapper.Map<List<JobPostingDetailResponse>>(Response.DataList), "");
		}

		[HttpGet]
		[Route("api/jobpostingdetailsingle")]
		[Produces(typeof(ServiceResponse<JobPostingDetailResponse>))]
		public async Task<ServiceResponse<JobPostingDetailResponse>> GetSingle([FromQuery] JobPostingDetailSelectSingle Model)
		{
			DataService<JobPostingDetail> Response = await Service.SelectSingleAsync(Model);
			return ServiceResponse<JobPostingDetailResponse>.SuccessResponse(Mapper.Map<JobPostingDetailResponse>(Response.Data), "");
		}
	}
}