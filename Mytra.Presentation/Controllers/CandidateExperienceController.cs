namespace Mytra.Presentation.Controllers
{
	using Core;
	using Common;
	using AutoMapper;
	using Microsoft.AspNetCore.Mvc;
	using Microsoft.AspNetCore.Authorization;

	[ApiController]
    public class CandidateExperienceController : ControllerBase
    {
		readonly IMapper Mapper;
		readonly ICandidateExperienceService Service;
		public CandidateExperienceController(IMapper mapper, ICandidateExperienceService service)
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
			return ServiceResponse<CandidateResponse>.SuccessResponse(Mapper.Map<List<CandidateResponse>>(Response.Data), "");
		}

		[HttpPost]
		[Authorize]
		[Route("api/candidateexperience")]
		[Produces(typeof(ServiceResponse<CandidateExperience>))]
		public async Task<ServiceResponse<CandidateExperience>> Create([FromBody] CandidateExperienceInsert Model)
		{
			DataService<CandidateExperience> Response = await Service.InsertAsync(Model);
			if (Response.Errors.Count > 0) return ServiceResponse<CandidateExperience>.FailureResponse(Response.Errors, "");
			if (!Response.Success) return ServiceResponse<CandidateExperience>.FailureResponse("");
			return ServiceResponse<CandidateExperience>.SuccessResponse(Response.Data, "");
		}

		[HttpPut]
		[Authorize]
		[Route("api/candidateexperience")]
		[Produces(typeof(ServiceResponse<CandidateExperience>))]
		public async Task<ServiceResponse<CandidateExperience>> Update([FromBody] CandidateExperienceUpdate Model)
		{
			DataService<CandidateExperience> Response = await Service.UpdateAsync(Model);
			if (Response.Errors.Count > 0) return ServiceResponse<CandidateExperience>.FailureResponse(Response.Errors, "");
			if (!Response.Success) return ServiceResponse<CandidateExperience>.FailureResponse("");
			return ServiceResponse<CandidateExperience>.SuccessResponse(Response.Data, "");
		}

		[HttpDelete]
		[Authorize]
		[Route("api/candidateexperience")]
		[Produces(typeof(ServiceResponse<CandidateExperience>))]
		public async Task<ServiceResponse<CandidateExperience>> Delete([FromBody] CandidateExperienceDelete Model)
		{
			DataService<CandidateExperience> Response = await Service.DeleteAsync(Model);
			if (Response.Errors.Count > 0) return ServiceResponse<CandidateExperience>.FailureResponse(Response.Errors, "");
			if (!Response.Success) return ServiceResponse<CandidateExperience>.FailureResponse("");
			return ServiceResponse<CandidateExperience>.SuccessResponse(Response.Data, "");
		}

		[HttpGet]
		[Authorize]
		[Route("api/candidateexperience")]
		[Produces(typeof(ServiceResponse<CandidateExperienceResponse>))]
		public async Task<ServiceResponse<CandidateExperienceResponse>> Get([FromQuery] CandidateExperienceSelect Model)
		{
			DataService<CandidateExperience> Response = await Service.SelectAsync(Model);
			return ServiceResponse<CandidateExperienceResponse>.SuccessResponse(Mapper.Map<List<CandidateExperienceResponse>>(Response.DataList), "");
		}

		[HttpGet]
		[Authorize]
		[Route("api/candidateexperiencesingle")]
		[Produces(typeof(ServiceResponse<CandidateExperienceResponse>))]
		public async Task<ServiceResponse<CandidateExperienceResponse>> GetSingle([FromQuery] CandidateExperienceSelectSingle Model)
		{
			DataService<CandidateExperience> Response = await Service.SelectSingleAsync(Model);
			return ServiceResponse<CandidateExperienceResponse>.SuccessResponse(Mapper.Map<List<CandidateExperienceResponse>>(Response.Data), "");
		}
	}
}