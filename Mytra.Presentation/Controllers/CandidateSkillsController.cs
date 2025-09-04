namespace Mytra.Presentation.Controllers
{
	using Core;
	using Common;
	using AutoMapper;
	using Microsoft.AspNetCore.Mvc;
	using Microsoft.AspNetCore.Authorization;

	[ApiController]
    public class CandidateSkillsController : ControllerBase
    {
		readonly IMapper Mapper;
		readonly ICandidateSkillsService Service;
		public CandidateSkillsController(IMapper mapper, ICandidateSkillsService service)
		{
			Mapper = mapper;
			Service = service;
		}

		[HttpPost]
		[Authorize]
		[Route("api/candidateskills")]
		[Produces(typeof(ServiceResponse<CandidateSkillsResponse>))]
		public async Task<ServiceResponse<CandidateSkillsResponse>> Create([FromBody] CandidateSkillsInsert Model)
		{
			DataService<CandidateSkills> Response = await Service.InsertAsync(Model);
			if (Response.Errors.Count > 0) return ServiceResponse<CandidateSkillsResponse>.FailureResponse(Response.Errors, "");
			if (!Response.Success) return ServiceResponse<CandidateSkillsResponse>.FailureResponse("");
			return ServiceResponse<CandidateSkillsResponse>.SuccessResponse(Mapper.Map<CandidateSkillsResponse>(Response.Data), "");
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
		[Produces(typeof(ServiceResponse<CandidateSkillsResponse>))]
		public async Task<ServiceResponse<CandidateSkillsResponse>> Get([FromQuery] CandidateSkillsSelect Model)
		{
			DataService<CandidateSkills> Response = await Service.SelectAsync(Model);
			return ServiceResponse<CandidateSkillsResponse>.SuccessResponse(Mapper.Map<List<CandidateSkillsResponse>>(Response.DataList), "");
		}

		[HttpGet]
		[Authorize]
		[Route("api/candidateskillssingle")]
		[Produces(typeof(ServiceResponse<CandidateSkillsResponse>))]
		public async Task<ServiceResponse<CandidateSkillsResponse>> GetSingle([FromQuery] CandidateSkillsSelectSingle Model)
		{
			DataService<CandidateSkills> Response = await Service.SelectSingleAsync(Model);
			return ServiceResponse<CandidateSkillsResponse>.SuccessResponse(Mapper.Map<List<CandidateSkillsResponse>>(Response.Data), "");
		}
	}
}