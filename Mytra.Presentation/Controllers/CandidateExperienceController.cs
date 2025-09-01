namespace Mytra.Presentation.Controllers
{
	using Core;
	using Common;
	using Microsoft.AspNetCore.Mvc;
	using Microsoft.AspNetCore.Authorization;

	[ApiController]
    public class CandidateExperienceController : ControllerBase
    {
		readonly ICandidateExperienceService Service;
		public CandidateExperienceController(ICandidateExperienceService service) { Service = service; }

		[HttpPost]
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
		[Route("api/candidateexperience")]
		[Produces(typeof(ServiceResponse<CandidateExperience>))]
		public async Task<ServiceResponse<CandidateExperience>> Get([FromQuery] CandidateExperienceSelect Model)
		{
			DataService<CandidateExperience> Response = await Service.SelectAsync(Model);
			return ServiceResponse<CandidateExperience>.SuccessResponse(Response.DataList, "");
		}

		[HttpGet]
		[Route("api/candidateexperiencesingle")]
		[Produces(typeof(ServiceResponse<CandidateExperience>))]
		public async Task<ServiceResponse<CandidateExperience>> GetSingle([FromQuery] CandidateExperienceSelectSingle Model)
		{
			DataService<CandidateExperience> Response = await Service.SelectSingleAsync(Model);
			return ServiceResponse<CandidateExperience>.SuccessResponse(Response.Data, "");
		}
	}
}