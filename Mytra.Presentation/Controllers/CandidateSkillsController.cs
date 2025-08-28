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
		[Produces(typeof(ServiceResponse<CandidateSkillsResponse>))]
		public async Task<ServiceResponse<CandidateSkillsResponse>> Create([FromBody] CandidateSkillsInsert Model)
		{
			ServiceResponse<CandidateSkillsResponse> Response = await Service.InsertAsync(Model);
			return new ServiceResponse<CandidateSkillsResponse>
			{
				ResponseData = Response.ResponseData
			};
		}
	}
}