namespace Mytra.Presentation.Controllers
{
	using Core;
	using Common;
	using Microsoft.AspNetCore.Mvc;
	using Microsoft.AspNetCore.Authorization;

    [ApiController]
    public class CandidateSkillsController : ControllerBase
    {
		readonly ICandidateSkillsService Service;
		public CandidateSkillsController(ICandidateSkillsService service) { Service = service; }

		[HttpPost]
		[Authorize]
		[Route("api/candidateskills")]
		[Produces(typeof(ServiceResponse<CandidateSkills>))]
		public async Task<ServiceResponse<CandidateSkills>> Create([FromBody] CandidateSkillsInsert Model)
		{
			DataService<CandidateSkills> Response = await Service.InsertAsync(Model);
			if (Response.Errors.Count > 0) return ServiceResponse<CandidateSkills>.FailureResponse(Response.Errors, "");
			if (!Response.Success) return ServiceResponse<CandidateSkills>.FailureResponse("");
			return ServiceResponse<CandidateSkills>.SuccessResponse(Response.Data, "");
		}

		[HttpPut]
		[Authorize]
		[Route("api/candidateskills")]
		[Produces(typeof(ServiceResponse<CandidateSkills>))]
		public async Task<ServiceResponse<CandidateSkills>> Update([FromBody] CandidateSkillsUpdate Model)
		{
			DataService<CandidateSkills> Response = await Service.UpdateAsync(Model);
			if (Response.Errors.Count > 0) return ServiceResponse<CandidateSkills>.FailureResponse(Response.Errors, "");
			if (!Response.Success) return ServiceResponse<CandidateSkills>.FailureResponse("");
			return ServiceResponse<CandidateSkills>.SuccessResponse(Response.Data, "");
		}

		[HttpDelete]
		[Authorize]
		[Route("api/candidateskills")]
		[Produces(typeof(ServiceResponse<CandidateSkills>))]
		public async Task<ServiceResponse<CandidateSkills>> Delete([FromBody] CandidateSkillsDelete Model)
		{
			DataService<CandidateSkills> Response = await Service.DeleteAsync(Model);
			if (Response.Errors.Count > 0) return ServiceResponse<CandidateSkills>.FailureResponse(Response.Errors, "");
			if (!Response.Success) return ServiceResponse<CandidateSkills>.FailureResponse("");
			return ServiceResponse<CandidateSkills>.SuccessResponse(Response.Data, "");
		}

		[HttpGet]
		[Authorize]
		[Route("api/candidateskills")]
		[Produces(typeof(ServiceResponse<CandidateSkills>))]
		public async Task<ServiceResponse<CandidateSkills>> Get([FromQuery] CandidateSkillsSelect Model)
		{
			DataService<CandidateSkills> Response = await Service.SelectAsync(Model);
			return ServiceResponse<CandidateSkills>.SuccessResponse(Response.DataList, "");
		}

		[HttpGet]
		[Authorize]
		[Route("api/candidateskillssingle")]
		[Produces(typeof(ServiceResponse<CandidateSkills>))]
		public async Task<ServiceResponse<CandidateSkills>> GetSingle([FromQuery] CandidateSkillsSelectSingle Model)
		{
			DataService<CandidateSkills> Response = await Service.SelectSingleAsync(Model);
			return ServiceResponse<CandidateSkills>.SuccessResponse(Response.Data, "");
		}
	}
}