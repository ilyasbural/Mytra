namespace Mytra.Presentation.Controllers
{
	using Core;
	using Utilize;
	using AutoMapper;
	using Microsoft.AspNetCore.Mvc;

	[ApiController]
    public class CandidateController : ControllerBase
    {
		readonly IMapper Mapper;
		readonly ICandidateService Service;
		public CandidateController(IMapper mapper, ICandidateService service)
		{
			Mapper = mapper;
			Service = service;
		}

		[HttpPost]
		[Route("api/candidate")]
		[Produces(typeof(ServiceResponse<CandidateResponse>))]
		public async Task<ServiceResponse<CandidateResponse>> Create([FromBody] CandidateInsert Model)
		{
			DataService<Candidate> Response = await Service.InsertAsync(Model);		
			if (Response.Errors.Count > 0) return ServiceResponse<CandidateResponse>.FailureResponse(Response.Errors, "");
			if (!Response.Success) return ServiceResponse<CandidateResponse>.FailureResponse("");
			return ServiceResponse<CandidateResponse>.SuccessResponse(Mapper.Map<CandidateResponse>(Response.Data), "");
		}

		[HttpPut]
		[Route("api/candidate")]
		[Produces(typeof(ServiceResponse<Candidate>))]
		public async Task<ServiceResponse<Candidate>> Update([FromBody] CandidateUpdate Model)
		{
			DataService<Candidate> Response = await Service.UpdateAsync(Model);
			if (Response.Errors.Count > 0) return ServiceResponse<Candidate>.FailureResponse(Response.Errors, "");
			if (!Response.Success) return ServiceResponse<Candidate>.FailureResponse("");
			return ServiceResponse<Candidate>.SuccessResponse(Response.Data, "");
		}

		[HttpDelete]
		[Route("api/candidate/{id}")]
		[Produces(typeof(ServiceResponse<Candidate>))]
		public async Task<ServiceResponse<Candidate>> Delete(Guid Id)
		{
			DataService<Candidate> Response = await Service.DeleteAsync(Id);
			if (Response.Errors.Count > 0) return ServiceResponse<Candidate>.FailureResponse(Response.Errors, "");
			if (!Response.Success) return ServiceResponse<Candidate>.FailureResponse("");
			return ServiceResponse<Candidate>.SuccessResponse(Response.Data, "");
		}

		[HttpGet]
		[Route("api/candidate")]
		[Produces(typeof(ServiceResponse<CandidateResponse>))]
		public async Task<ServiceResponse<CandidateResponse>> Get([FromQuery] CandidateSelect Model)
		{
			DataService<Candidate> Response = await Service.SelectAsync(Model);
			return ServiceResponse<CandidateResponse>.SuccessResponse(Mapper.Map<List<CandidateResponse>>(Response.DataList), "");
		}

		[HttpGet]
		[Route("api/candidatesingle")]
		[Produces(typeof(ServiceResponse<CandidateResponse>))]
		public async Task<ServiceResponse<CandidateResponse>> GetSingle([FromQuery] CandidateSelectSingle Model)
		{
			DataService<Candidate> Response = await Service.SelectSingleAsync(Model);
			return ServiceResponse<CandidateResponse>.SuccessResponse(Mapper.Map<CandidateResponse>(Response.Data), "");
		}
	}
}