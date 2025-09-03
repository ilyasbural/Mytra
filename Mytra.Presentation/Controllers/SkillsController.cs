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
		[Produces(typeof(ServiceResponse<Skills>))]
		public async Task<ServiceResponse<Skills>> Create([FromBody] SkillsInsert Model)
		{
			DataService<Skills> Response = await Service.InsertAsync(Model);
			if (Response.Errors.Count > 0) return ServiceResponse<Skills>.FailureResponse(Response.Errors, "");
			if (!Response.Success) return ServiceResponse<Skills>.FailureResponse("");
			return ServiceResponse<Skills>.SuccessResponse(Response.Data, "");
		}

		[HttpPut]
		[Authorize]
		[Route("api/skills")]
		[Produces(typeof(ServiceResponse<Skills>))]
		public async Task<ServiceResponse<Skills>> Update([FromBody] SkillsUpdate Model)
		{
			DataService<Skills> Response = await Service.UpdateAsync(Model);
			if (Response.Errors.Count > 0) return ServiceResponse<Skills>.FailureResponse(Response.Errors, "");
			if (!Response.Success) return ServiceResponse<Skills>.FailureResponse("");
			return ServiceResponse<Skills>.SuccessResponse(Response.Data, "");
		}

		[HttpDelete]
		[Authorize]
		[Route("api/skills")]
		[Produces(typeof(ServiceResponse<Skills>))]
		public async Task<ServiceResponse<Skills>> Delete([FromBody] SkillsDelete Model)
		{
			DataService<Skills> Response = await Service.DeleteAsync(Model);
			if (Response.Errors.Count > 0) return ServiceResponse<Skills>.FailureResponse(Response.Errors, "");
			if (!Response.Success) return ServiceResponse<Skills>.FailureResponse("");
			return ServiceResponse<Skills>.SuccessResponse(Response.Data, "");
		}

		[HttpGet]
		[Authorize]
		[Route("api/skills")]
		[Produces(typeof(ServiceResponse<Skills>))]
		public async Task<ServiceResponse<Skills>> Get([FromQuery] SkillsSelect Model)
		{
			DataService<Skills> Response = await Service.SelectAsync(Model);
			return ServiceResponse<Skills>.SuccessResponse(Response.DataList, "");
		}

		[HttpGet]
		[Authorize]
		[Route("api/skillssingle")]
		[Produces(typeof(ServiceResponse<Skills>))]
		public async Task<ServiceResponse<Skills>> GetSingle([FromQuery] SkillsSelectSingle Model)
		{
			DataService<Skills> Response = await Service.SelectSingleAsync(Model);
			return ServiceResponse<Skills>.SuccessResponse(Response.Data, "");
		}
	}
}