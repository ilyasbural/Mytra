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
		[Route("api/candidateskills")]
		[Produces(typeof(ServiceResponse<CandidateSkills>))]
		public async Task<ServiceResponse<CandidateSkills>> Create([FromBody] CandidateSkillsInsert Model)
		{
			DataService<CandidateSkills> Response = await Service.InsertAsync(Model);
			if (Response.Errors.Count > 0) return ServiceResponse<CandidateSkills>.FailureResponse(Response.Errors, "");
			if (!Response.Success) return ServiceResponse<CandidateSkills>.FailureResponse("");
			return ServiceResponse<CandidateSkills>.SuccessResponse(Response.Data, "");
		}

		//[HttpPut]
		//[Route("api/candidateskills")]
		//[Produces(typeof(ServiceResponse<CandidateSkillsResponse>))]
		//public async Task<ServiceResponse<CandidateSkillsResponse>> Update([FromBody] CandidateSkillsUpdate Model)
		//{
		//	ServiceResponse<CandidateSkillsResponse> Response = await Service.UpdateAsync(Model);
		//	return new ServiceResponse<CandidateSkillsResponse>
		//	{
		//		Success = Response.Success,
		//		ResponseData = Response.ResponseData
		//	};
		//}

		//[HttpDelete]
		//[Route("api/candidateskills")]
		//[Produces(typeof(ServiceResponse<CandidateSkillsResponse>))]
		//public async Task<ServiceResponse<CandidateSkillsResponse>> Delete([FromBody] CandidateSkillsDelete Model)
		//{
		//	ServiceResponse<CandidateSkillsResponse> Response = await Service.DeleteAsync(Model);
		//	return new ServiceResponse<CandidateSkillsResponse>
		//	{
		//		Success = Response.Success,
		//		ResponseData = Response.ResponseData
		//	};
		//}

		[HttpGet]
		[Route("api/candidateskills")]
		[Produces(typeof(ServiceResponse<CandidateSkills>))]
		public async Task<ServiceResponse<CandidateSkills>> Get([FromQuery] CandidateSkillsSelect Model)
		{
			DataService<CandidateSkills> Response = await Service.SelectAsync(Model);
			return ServiceResponse<CandidateSkills>.SuccessResponse(Response.DataList, "candidateskills list");
		}

		//[HttpGet]
		//[Route("api/candidateskillssingle")]
		//[Produces(typeof(ServiceResponse<CandidateSkillsResponse>))]
		//public async Task<ServiceResponse<CandidateSkillsResponse>> GetSingle([FromQuery] CandidateSkillsSelectSingle Model)
		//{
		//	ServiceResponse<CandidateSkillsResponse> Response = await Service.SelectSingleAsync(Model);
		//	return new ServiceResponse<CandidateSkillsResponse>
		//	{
		//		ResponseDataSource = Response.ResponseDataSource
		//	};
		//}
	}
}