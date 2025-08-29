namespace Mytra.Presentation.Controllers
{
	using Core;
	using Common;
	using Microsoft.AspNetCore.Mvc;
	using Microsoft.AspNetCore.Authorization;

	[ApiController]
	public class SkillsController : ControllerBase
	{
		readonly ISkillsService Service;
		public SkillsController(ISkillsService service) { Service = service; }

		[HttpPost]
		[Authorize]
		[Route("api/skills")]
		[Produces(typeof(ServiceResponse<SkillsResponse>))]
		public async Task<ServiceResponse<SkillsResponse>> Create([FromBody] SkillsInsert Model)
		{
			ServiceResponse<SkillsResponse> Response = await Service.InsertAsync(Model);
			return new ServiceResponse<SkillsResponse>
			{
				ResponseData = Response.ResponseData
			};
		}

		[HttpPut]
		[Authorize]
		[Route("api/skills")]
		[Produces(typeof(ServiceResponse<SkillsResponse>))]
		public async Task<ServiceResponse<SkillsResponse>> Update([FromBody] SkillsUpdate Model)
		{
			ServiceResponse<SkillsResponse> Response = await Service.UpdateAsync(Model);
			return new ServiceResponse<SkillsResponse>
			{
				ResponseData = Response.ResponseData
			};
		}

		[HttpDelete]
		[Authorize]
		[Route("api/skills")]
		[Produces(typeof(ServiceResponse<SkillsResponse>))]
		public async Task<ServiceResponse<SkillsResponse>> Delete([FromBody] SkillsDelete Model)
		{
			ServiceResponse<SkillsResponse> Response = await Service.DeleteAsync(Model);
			return new ServiceResponse<SkillsResponse>
			{
				ResponseData = Response.ResponseData
			};
		}
	}
}