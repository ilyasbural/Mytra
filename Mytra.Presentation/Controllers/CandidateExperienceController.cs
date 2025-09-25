namespace Mytra.Presentation.Controllers
{
	using Core;
	using Utilize;
	using AutoMapper;
	using Microsoft.AspNetCore.Mvc;

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
		[Route("api/candidateexperience")]
		[Produces(typeof(ServiceResponse<CandidateExperienceResponse>))]
		public async Task<ServiceResponse<CandidateExperienceResponse>> Create([FromBody] CandidateExperienceInsert Model)
		{
			DataService<CandidateExperience> Response = await Service.InsertAsync(Model);
			if (Response.Errors.Count > 0) return ServiceResponse<CandidateExperienceResponse>.FailureResponse(Response.Errors, "");
			if (!Response.Success) return ServiceResponse<CandidateExperienceResponse>.FailureResponse("");
			return ServiceResponse<CandidateExperienceResponse>.SuccessResponse(Mapper.Map<CandidateExperienceResponse>(Response.Data), "");
		}

		[HttpPut]
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
		[Route("api/candidateexperience/{id}")]
		[Produces(typeof(ServiceResponse<CandidateExperience>))]
		public async Task<ServiceResponse<CandidateExperience>> Delete(Guid Id)
		{
			DataService<CandidateExperience> Response = await Service.DeleteAsync(Id);
			if (Response.Errors.Count > 0) return ServiceResponse<CandidateExperience>.FailureResponse(Response.Errors, "");
			if (!Response.Success) return ServiceResponse<CandidateExperience>.FailureResponse("");
			return ServiceResponse<CandidateExperience>.SuccessResponse(Response.Data, "");
		}

		[HttpGet]
		[Route("api/candidateexperience")]
		[Produces(typeof(ServiceResponse<CandidateExperienceResponse>))]
		public async Task<ServiceResponse<CandidateExperienceResponse>> Get([FromQuery] CandidateExperienceSelect Model)
		{
			DataService<CandidateExperience> Response = await Service.SelectAsync(Model);
			return ServiceResponse<CandidateExperienceResponse>.SuccessResponse(Mapper.Map<List<CandidateExperienceResponse>>(Response.DataList), "");
		}

		[HttpGet]
		[Route("api/candidateexperiencesingle")]
		[Produces(typeof(ServiceResponse<CandidateExperienceResponse>))]
		public async Task<ServiceResponse<CandidateExperienceResponse>> GetSingle([FromQuery] CandidateExperienceSelectSingle Model)
		{
			DataService<CandidateExperience> Response = await Service.SelectSingleAsync(Model);
			return ServiceResponse<CandidateExperienceResponse>.SuccessResponse(Mapper.Map<CandidateExperienceResponse>(Response.Data), "");
		}
	}
}