namespace Mytra.Presentation.Controllers
{
	using Core;
	using Utilize;
	using AutoMapper;
	using Microsoft.AspNetCore.Mvc;

	[ApiController]
    public class JobPostingController : ControllerBase
    {
		readonly IMapper Mapper;
		readonly IJobPostingService Service;
		public JobPostingController(IMapper mapper, IJobPostingService service)
		{
			Mapper = mapper;
			Service = service;
		}

		[HttpPost]
		[Route("api/jobposting")]
		[Produces(typeof(ServiceResponse<JobPostingResponse>))]
		public async Task<ServiceResponse<JobPostingResponse>> Create([FromBody] JobPostingInsert Model)
		{
			DataService<JobPosting> Response = await Service.InsertAsync(Model);
			if (Response.Errors.Count > 0) return ServiceResponse<JobPostingResponse>.FailureResponse(Response.Errors, "");
			if (!Response.Success) return ServiceResponse<JobPostingResponse>.FailureResponse("");
			return ServiceResponse<JobPostingResponse>.SuccessResponse(Mapper.Map<JobPostingResponse>(Response.Data), "");
		}

		[HttpPut]
		[Route("api/jobposting")]
		[Produces(typeof(ServiceResponse<JobPosting>))]
		public async Task<ServiceResponse<JobPosting>> Update([FromBody] JobPostingUpdate Model)
		{
			DataService<JobPosting> Response = await Service.UpdateAsync(Model);
			if (Response.Errors.Count > 0) return ServiceResponse<JobPosting>.FailureResponse(Response.Errors, "");
			if (!Response.Success) return ServiceResponse<JobPosting>.FailureResponse("");
			return ServiceResponse<JobPosting>.SuccessResponse(Response.Data, "");
		}

		[HttpDelete]
		[Route("api/jobposting/{id}")]
		[Produces(typeof(ServiceResponse<JobPosting>))]
		public async Task<ServiceResponse<JobPosting>> Delete(Guid Id)
		{
			DataService<JobPosting> Response = await Service.DeleteAsync(Id);
			if (Response.Errors.Count > 0) return ServiceResponse<JobPosting>.FailureResponse(Response.Errors, "");
			if (!Response.Success) return ServiceResponse<JobPosting>.FailureResponse("");
			return ServiceResponse<JobPosting>.SuccessResponse(Response.Data, "");
		}

		[HttpGet]
		[Route("api/jobposting")]
		[Produces(typeof(ServiceResponse<JobPostingResponse>))]
		public async Task<ServiceResponse<JobPostingResponse>> Get([FromQuery] JobPostingSelect Model)
		{
			DataService<JobPosting> Response = await Service.SelectAsync(Model);
			return ServiceResponse<JobPostingResponse>.SuccessResponse(Mapper.Map<List<JobPostingResponse>>(Response.DataList), "");
		}

		[HttpGet]
		[Route("api/jobpostingsingle")]
		[Produces(typeof(ServiceResponse<JobPostingResponse>))]
		public async Task<ServiceResponse<JobPostingResponse>> GetSingle([FromQuery] JobPostingSelectSingle Model)
		{
			DataService<JobPosting> Response = await Service.SelectSingleAsync(Model);
			return ServiceResponse<JobPostingResponse>.SuccessResponse(Mapper.Map<JobPostingResponse>(Response.Data), "");
		}
	}
}