namespace Mytra.Presentation.Controllers
{
	using Core;
	using Utilize;
	using AutoMapper;
	using Microsoft.AspNetCore.Mvc;

	[ApiController]
    public class JobPostingVisitController : ControllerBase
    {
		readonly IMapper Mapper;
		readonly IJobPostingVisitService Service;
		public JobPostingVisitController(IMapper mapper, IJobPostingVisitService service)
		{
			Mapper = mapper;
			Service = service;
		}

		[HttpPost]
		[Route("api/jobpostingvisit")]
		[Produces(typeof(ServiceResponse<JobPostingVisitResponse>))]
		public async Task<ServiceResponse<JobPostingVisitResponse>> Create([FromBody] JobPostingVisitInsert Model)
		{
			DataService<JobPostingVisit> Response = await Service.InsertAsync(Model);
			if (Response.Errors.Count > 0) return ServiceResponse<JobPostingVisitResponse>.FailureResponse(Response.Errors, "");
			if (!Response.Success) return ServiceResponse<JobPostingVisitResponse>.FailureResponse("");
			return ServiceResponse<JobPostingVisitResponse>.SuccessResponse(Mapper.Map<JobPostingVisitResponse>(Response.Data), "");
		}

		[HttpPut]
		[Route("api/jobpostingvisit")]
		[Produces(typeof(ServiceResponse<JobPostingVisit>))]
		public async Task<ServiceResponse<JobPostingVisit>> Update([FromBody] JobPostingVisitUpdate Model)
		{
			DataService<JobPostingVisit> Response = await Service.UpdateAsync(Model);
			if (Response.Errors.Count > 0) return ServiceResponse<JobPostingVisit>.FailureResponse(Response.Errors, "");
			if (!Response.Success) return ServiceResponse<JobPostingVisit>.FailureResponse("");
			return ServiceResponse<JobPostingVisit>.SuccessResponse(Response.Data, "");
		}

		[HttpDelete]
		[Route("api/jobpostingvisit/{id}")]
		[Produces(typeof(ServiceResponse<JobPostingVisit>))]
		public async Task<ServiceResponse<JobPostingVisit>> Delete(Guid Id)
		{
			DataService<JobPostingVisit> Response = await Service.DeleteAsync(Id);
			if (Response.Errors.Count > 0) return ServiceResponse<JobPostingVisit>.FailureResponse(Response.Errors, "");
			if (!Response.Success) return ServiceResponse<JobPostingVisit>.FailureResponse("");
			return ServiceResponse<JobPostingVisit>.SuccessResponse(Response.Data, "");
		}

		[HttpGet]
		[Route("api/jobpostingvisit")]
		[Produces(typeof(ServiceResponse<JobPostingVisitResponse>))]
		public async Task<ServiceResponse<JobPostingVisitResponse>> Get([FromQuery] JobPostingVisitSelect Model)
		{
			DataService<JobPostingVisit> Response = await Service.SelectAsync(Model);
			return ServiceResponse<JobPostingVisitResponse>.SuccessResponse(Mapper.Map<List<JobPostingVisitResponse>>(Response.DataList), "");
		}

		[HttpGet]
		[Route("api/jobpostingvisitsingle")]
		[Produces(typeof(ServiceResponse<JobPostingVisitResponse>))]
		public async Task<ServiceResponse<JobPostingVisitResponse>> GetSingle([FromQuery] JobPostingVisitSelectSingle Model)
		{
			DataService<JobPostingVisit> Response = await Service.SelectSingleAsync(Model);
			return ServiceResponse<JobPostingVisitResponse>.SuccessResponse(Mapper.Map<JobPostingVisitResponse>(Response.Data), "");
		}
	}
}