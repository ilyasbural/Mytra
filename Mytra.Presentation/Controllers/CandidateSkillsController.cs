namespace Mytra.Presentation.Controllers
{
	using Core;
	using Utilize;
	using AutoMapper;
	using Microsoft.AspNetCore.Mvc;

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
		[Route("api/candidateskills/{id}")]
		[Produces(typeof(ServiceResponse<CandidateSkills>))]
		public async Task<ServiceResponse<CandidateSkills>> Delete(Guid Id)
		{
			DataService<CandidateSkills> Response = await Service.DeleteAsync(Id);
			if (Response.Errors.Count > 0) return ServiceResponse<CandidateSkills>.FailureResponse(Response.Errors, "");
			if (!Response.Success) return ServiceResponse<CandidateSkills>.FailureResponse("");
			return ServiceResponse<CandidateSkills>.SuccessResponse(Response.Data, "");
		}

		[HttpGet]
		[Route("api/candidateskills")]
		[Produces(typeof(ServiceResponse<CandidateSkillsResponse>))]
		public async Task<ServiceResponse<CandidateSkillsResponse>> Get([FromQuery] CandidateSkillsSelect Model)
		{
			DataService<CandidateSkills> Response = await Service.SelectAsync(Model);
			return ServiceResponse<CandidateSkillsResponse>.SuccessResponse(Mapper.Map<List<CandidateSkillsResponse>>(Response.DataList), "");
		}

		[HttpGet]
		[Route("api/candidateskillssingle")]
		[Produces(typeof(ServiceResponse<CandidateSkillsResponse>))]
		public async Task<ServiceResponse<CandidateSkillsResponse>> GetSingle([FromQuery] CandidateSkillsSelectSingle Model)
		{
			DataService<CandidateSkills> Response = await Service.SelectSingleAsync(Model);
			return ServiceResponse<CandidateSkillsResponse>.SuccessResponse(Mapper.Map<CandidateSkillsResponse>(Response.Data), "");
		}
	}
}